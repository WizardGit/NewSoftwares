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
    public partial class AddBankForm : Form
    {
        public AddBankForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBankBtn_Click(object sender, EventArgs e)
        {
            List<string> idNumbers = new List<string>();
            idNumbers.Add("1000");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select BankId from tblBank order by BankId desc", con);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    idNumbers.Add(string.Format("{0}", reader["BankId"]));
            }


            int.TryParse(idNumbers[idNumbers.Count - 1], out int BankId);
            BankId++;

            SqlCommand cmd = new SqlCommand("insert into tblBank values('" + BankId + "', '" + bankTxtBox.Text + "','" + ImpInfo.userId + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void AddBankForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.tblBank' table. You can move, or remove it, as needed.
            this.tblBankTableAdapter.Fill(this.mainDatabaseDataSet.tblBank);

        }
    }
}
