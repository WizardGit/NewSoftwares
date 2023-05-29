using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgette
{
    public partial class AddBucketForm : Form
    {
        public AddBucketForm()
        {
            InitializeComponent();
        }
        private void AddBucketForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.tblBucket' table. You can move, or remove it, as needed.
            this.tblBucketTableAdapter.Fill(this.mainDatabaseDataSet.tblBucket);
        }

        private void createBucketBtn_Click(object sender, EventArgs e)
        {
            List<string> idNumbers = new List<string> { "1000" };

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select BucketId from tblBucket order by BucketId desc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    idNumbers.Add(string.Format("{0}", reader["BucketId"]));
            }


            int.TryParse(idNumbers[idNumbers.Count - 1], out int bucketId);
            bucketId++;

            decimal.TryParse(balanceTxtBox.Text, out decimal balance);

            SqlCommand cmd = new SqlCommand("insert into tblBucket values('" + bucketId + "', '" + balance + "', '" + ImpInfo.userId + "','" + nameTxtBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
