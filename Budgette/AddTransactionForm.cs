﻿using System;
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

            SqlCommand cmd = new SqlCommand("insert into tblTransaction values(" +
                "'" + transactionId + "', '" + ImpInfo.userId + "', GetDate(), " +
                "'" + accountFromComboBox.Text + "','" + accountToComboBox.Text + "'," +
                "'" + bucketFromComboBox.Text + "','" + bucketToComboBox.Text + "', " +
                "'" + bankFromComboBox.Text + "', '" + bankToComboBox.Text + "', " +
                "'" + balance + "')", con);
            cmd.ExecuteNonQuery();            

            if ((accountFromComboBox.Text != "") && (bucketFromComboBox.Text != "") && (bankFromComboBox.Text != ""))
            {
                SqlCommand cmd1 = new SqlCommand("select Balance from tblAccount where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankFromComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "')", con);
                string strAccountBalance;
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                        strAccountBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decAccountBalance);

                SqlCommand cmd2 = new SqlCommand("select Balance from tblBucket where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketFromComboBox.Text + "')", con);
                string strBucketBalance;
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                        strBucketBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decBucketBalance);

                SqlCommand cmd3 = new SqlCommand("update tblAccount set Balance = '" + (decAccountBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankFromComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "')", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("update tblBucket set Balance = '" + (decBucketBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketFromComboBox.Text + "')", con);
                cmd4.ExecuteNonQuery();
            }
            if ((accountToComboBox.Text != "") && (bucketToComboBox.Text != "") && (bankToComboBox.Text != ""))
            {
                SqlCommand cmd1 = new SqlCommand("select Balance from tblAccount where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankToComboBox.Text + "' and Name = '" + accountToComboBox.Text + "')", con);
                string strAccountBalance;
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                        strAccountBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decAccountBalance);

                SqlCommand cmd2 = new SqlCommand("select Balance from tblBucket where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketToComboBox.Text + "')", con);
                string strBucketBalance;
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                        strBucketBalance = string.Format("{0}", reader["Balance"]);
                }
                decimal.TryParse(amountTxtBox.Text, out decimal decBucketBalance);

                SqlCommand cmd3 = new SqlCommand("update tblAccount set Balance = '" + (decAccountBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Bank = '" + bankToComboBox.Text + "' and Name = '" + accountFromComboBox.Text + "')", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("update tblBucket set Balance = '" + (decBucketBalance - balance) + "' where UserId = '" + ImpInfo.userId + "' and Name = '" + bucketToComboBox.Text + "')", con);
                cmd4.ExecuteNonQuery();
            }            

            con.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool CompleteTransaction()
        {

            return true;
        }
    }
}
