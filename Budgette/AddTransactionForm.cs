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
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            List<string> idNumbers = new List<string>();
            idNumbers.Add("1000");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select TransactionId from tblTransaction order by TransactionId desc", con);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    idNumbers.Add(string.Format("{0}", reader["TransactionId"]));
            }


            int.TryParse(idNumbers[idNumbers.Count - 1], out int transactionId);
            transactionId++;

            decimal.TryParse(amountTxtBox.Text, out decimal balance);

            SqlCommand cmd = new SqlCommand("insert into tblAccount values('" + transactionId + "', '" + bankNameTxtBox.Text + "','" + accountFromTxtBox.Text + "','" + accountToTxtBox.Text + "','" + bucketToTxtBox.Text + "','" + bucketFromTxtBox.Text + "', '" + balance + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
