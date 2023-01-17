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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.tblAccount' table. You can move, or remove it, as needed.
            this.tblAccountTableAdapter.Fill(this.mainDatabaseDataSet.tblAccount);


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select Name from tblBank where UserId= '" + ImpInfo.userId + "' order by Name asc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    bankComboBox.Items.Add(string.Format("{0}", reader["Name"]));
            }


            con.Close();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            List<string> idNumbers = new List<string>();
            idNumbers.Add("1000");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select AccountId from tblAccount order by AccountId desc", con);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    idNumbers.Add(string.Format("{0}", reader["AccountId"]));
            }


            int.TryParse(idNumbers[idNumbers.Count - 1], out int accountId);
            accountId++;

            decimal.TryParse(balanceTxtBox.Text, out decimal balance);

            SqlCommand cmd = new SqlCommand("insert into tblAccount values('" + accountId + "', '" + bankComboBox.Text + "','" + nameTxtBox.Text + "', '" + balance + "', '" + ImpInfo.userId + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            tblAccountDataGridView.Update();
            tblAccountDataGridView.Refresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
