using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgette
{
    // The problem here is that you can choose ANY account with a certain bank so there could be errors, you should only be allowed to choose from the combo box what is attached to the chosen bank!
    public partial class AddTransactionForm : Form
    {
        public string transType;
        public AddTransactionForm(string localTransType)
        {
            InitializeComponent();
            //this.Name = localTransType;
            transType = localTransType;
            if (localTransType == "withdraw")
            {
                accountToComboBox.Visible = false;
                bucketToComboBox.Visible = false;
                bankToComboBox.Visible = false;
                entityFromTxtBox.Visible = false;

                accountToLbl.Visible = false;
                bucketToLbl.Visible = false;
                BankToLbl.Visible = false;
                entityFromLbl.Visible = false;
            }
            else if(localTransType == "deposit")
            {
                accountFromComboBox.Visible = false;
                bucketFromComboBox.Visible = false;
                bankFromComboBox.Visible = false;
                entityToTxtBox.Visible = false;

                accountFromLbl.Visible = false;
                bucketFromLbl.Visible = false;
                bankFromLbl.Visible = false;
                entityToLbl.Visible = false;
            }
            else if (localTransType == "transfer")
            {
                entityFromTxtBox.Visible = false;
                entityToTxtBox.Visible = false;

                entityToLbl.Visible = false;
                entityFromLbl.Visible = false;
            }
            else
            {
                Console.Write("Unknown Transfer initiated!");
            }
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.tblBucket' table. You can move, or remove it, as needed.
            this.tblTransactionTableAdapter.Fill(this.mainDatabaseDataSet.tblTransaction);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select Name from tblBank where UserId= '" + ImpInfo.userId + "' order by Name asc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    bankFromComboBox.Items.Add(string.Format("{0}", reader["Name"]));
                    bankToComboBox.Items.Add(string.Format("{0}", reader["Name"]));
                }
            }
            command = new SqlCommand("Select Name from tblBucket where UserId= '" + ImpInfo.userId + "' order by Name asc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    bucketFromComboBox.Items.Add(string.Format("{0}", reader["Name"]));
                    bucketToComboBox.Items.Add(string.Format("{0}", reader["Name"]));
                }
            }
            command = new SqlCommand("Select Name from tblAccount where UserId= '" + ImpInfo.userId + "' order by Name asc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    accountFromComboBox.Items.Add(string.Format("{0}", reader["Name"]));
                    accountToComboBox.Items.Add(string.Format("{0}", reader["Name"]));
                }
            }

            con.Close();
        }


        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            List<string> idNumbers = new List<string> { "1000" };

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select TransactionId from tblTransaction order by TransactionId desc", con);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    idNumbers.Add(string.Format("{0}", reader["TransactionId"]));
            }
            con.Close();
            int.TryParse(idNumbers[idNumbers.Count - 1], out int transactionId);
            transactionId++;            

            if (transType == "withdraw")
                PerformWithdraw(transactionId);
            else if (transType == "deposit")
                PerformDeposit(transactionId);
            else if (transType == "transfer")
                PerformTransfer(transactionId);
            else
                Console.Write("Unknown Transfer initiated!");
            this.Close();
        }   
        
        private bool PerformWithdraw(int transactionId)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            decimal.TryParse(amountTxtBox.Text, out decimal balance);

            SqlCommand cmd = new SqlCommand("insert into tblTransaction values(" +
                "'" + transactionId + "', '" + ImpInfo.userId + "', GetDate(), " +
                "'" + accountFromComboBox.Text + "','" + accountToComboBox.Text + "'," +
                "'" + bucketFromComboBox.Text + "','" + bucketToComboBox.Text + "', " +
                "'" + bankFromComboBox.Text + "', '" + bankToComboBox.Text + "', " +
                "'" + entityFromTxtBox.Text + "', '" + entityToTxtBox.Text + "', " +
                "'" + balance + "', " + descriptionTxtBox.Text + "')", con);
            cmd.ExecuteNonQuery();

            if ((accountFromComboBox.Text != "") && (bucketFromComboBox.Text != "") && (bankFromComboBox.Text != ""))
            {
                SqlCommand cmd1 = new SqlCommand("select Balance from tblAccount where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankFromComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "'", con);
                string strAccountBalance;
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                        strAccountBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decAccountBalance);

                SqlCommand cmd2 = new SqlCommand("select Balance from tblBucket where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketFromComboBox.Text + "'", con);
                string strBucketBalance;
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                        strBucketBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decBucketBalance);

                SqlCommand cmd3 = new SqlCommand("update tblAccount set Balance = '" + (decAccountBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankFromComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "'", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("update tblBucket set Balance = '" + (decBucketBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketFromComboBox.Text + "'", con);
                cmd4.ExecuteNonQuery();
            }

            con.Close();
            return true;
        }

        private bool PerformDeposit(int transactionId)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            decimal.TryParse(amountTxtBox.Text, out decimal balance);

            SqlCommand cmd = new SqlCommand("insert into tblTransaction values(" +
                "'" + transactionId + "', '" + ImpInfo.userId + "', GetDate(), " +
                "'" + accountFromComboBox.Text + "','" + accountToComboBox.Text + "'," +
                "'" + bucketFromComboBox.Text + "','" + bucketToComboBox.Text + "', " +
                "'" + bankFromComboBox.Text + "', '" + bankToComboBox.Text + "', " +
                "'" + entityFromTxtBox.Text + "', '" + entityToTxtBox.Text + "', " +
                "'" + balance + "', '" + descriptionTxtBox.Text + "')", con);
            cmd.ExecuteNonQuery();

            Debug.WriteLine("start");
            if ((accountToComboBox.Text != "") && (bucketToComboBox.Text != "") && (bankToComboBox.Text != ""))
            {
                SqlCommand cmd1 = new SqlCommand("select Balance from tblAccount where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankToComboBox.Text + "' and Name = '" + accountToComboBox.Text + "'", con);
                string strAccountBalance = "";
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                        strAccountBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(strAccountBalance, out decimal decAccountBalance);

                SqlCommand cmd2 = new SqlCommand("select Balance from tblBucket where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketToComboBox.Text + "'", con);
                string strBucketBalance = "";
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                        strBucketBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(strBucketBalance, out decimal decBucketBalance);

                Debug.WriteLine((decAccountBalance + balance));

                SqlCommand cmd3 = new SqlCommand("update tblAccount set Balance = '" + (decAccountBalance + balance) + "' where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankToComboBox.Text + "' and Name = '" + accountToComboBox.Text + "'", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("update tblBucket set Balance = '" + (decBucketBalance + balance) + "' where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketToComboBox.Text + "'", con);
                cmd4.ExecuteNonQuery();
            }

            con.Close();
            return true;
        }

        private bool PerformTransfer(int transNum)
        {

            int transactionId = transNum;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            decimal.TryParse(amountTxtBox.Text, out decimal balance);

            SqlCommand cmd = new SqlCommand("insert into tblTransaction values(" +
                "'" + transactionId + "', '" + ImpInfo.userId + "', GetDate(), " +
                "'" + accountFromComboBox.Text + "','" + accountToComboBox.Text + "'," +
                "'" + bucketFromComboBox.Text + "','" + bucketToComboBox.Text + "', " +
                "'" + bankFromComboBox.Text + "', '" + bankToComboBox.Text + "', " +
                "'" + entityFromTxtBox.Text + "', '" + entityToTxtBox.Text + "', " +
                "'" + balance + "', " + descriptionTxtBox.Text + "')", con);
            cmd.ExecuteNonQuery();

            if ((accountFromComboBox.Text != "") && (bucketFromComboBox.Text != "") && (bankFromComboBox.Text != ""))
            {
                SqlCommand cmd1 = new SqlCommand("select Balance from tblAccount where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankFromComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "'", con);
                string strAccountBalance;
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                        strAccountBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decAccountBalance);

                SqlCommand cmd2 = new SqlCommand("select Balance from tblBucket where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketFromComboBox.Text + "'", con);
                string strBucketBalance;
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                        strBucketBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decBucketBalance);

                SqlCommand cmd3 = new SqlCommand("update tblAccount set Balance = '" + (decAccountBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankFromComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "'", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("update tblBucket set Balance = '" + (decBucketBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketFromComboBox.Text + "'", con);
                cmd4.ExecuteNonQuery();
            }
            if ((accountToComboBox.Text != "") && (bucketToComboBox.Text != "") && (bankToComboBox.Text != ""))
            {
                SqlCommand cmd1 = new SqlCommand("select Balance from tblAccount where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankToComboBox.Text + "' and Name = '" + accountToComboBox.Text + "'", con);
                string strAccountBalance;
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                        strAccountBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decAccountBalance);

                SqlCommand cmd2 = new SqlCommand("select Balance from tblBucket where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketToComboBox.Text + "'", con);
                string strBucketBalance;
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                        strBucketBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decBucketBalance);

                SqlCommand cmd3 = new SqlCommand("update tblAccount set Balance = '" + (decAccountBalance + balance) + "' where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankToComboBox.Text + "' and Name = '" + accountToComboBox.Text + "'", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("update tblBucket set Balance = '" + (decBucketBalance + balance) + "' where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketToComboBox.Text + "'", con);
                cmd4.ExecuteNonQuery();
            }

            con.Close();
            return true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
