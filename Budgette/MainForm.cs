using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgette
{    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserform = new AddUserForm();
            addUserform.Show();            
        }

        private void AddBankAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccount = new AddAccountForm();
            addAccount.Show();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBucketBtn_Click(object sender, EventArgs e)
        {
            AddBucketForm addBucket = new AddBucketForm();
            addBucket.Show();
        }

        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransaction = new AddTransactionForm("transfer");
            addTransaction.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;  

            if ((username.Length > ImpInfo.maxChar) || (password.Length > ImpInfo.maxChar))
            {
                userLbl.Text = "Error! Password/Username is too long!";
                return;
            }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select UserId from tblUser where Username='" + username + "' and Password='" + password + "'", con);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {                
                if (reader.Read())
                {

                    int.TryParse(string.Format("{0}", reader["UserId"]), out ImpInfo.userId);
                    ImpInfo.username = username;
                    userLbl.Text = "Current user is: " + username;
                }
                else
                {
                    userLbl.Text = "Error! User Unrecognized!";
                }
            }

            con.Close();
        }

        private void AddBankBtn_Click(object sender, EventArgs e)
        {
            AddBankForm addBank = new AddBankForm();
            addBank.Show();
        }

        private void DbBackupBtn_Click(object sender, EventArgs e)
        {
            BackupsForm backupsForm = new BackupsForm();
            backupsForm.Show();
        }

        private void MakeTransferBtn_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransaction = new AddTransactionForm("transfer");
            addTransaction.Show();
        }

        private void MakeWithdrawBtn_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransaction = new AddTransactionForm("withdraw");
            addTransaction.Show();
        }

        private void MakeDepositBtn_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransaction = new AddTransactionForm("deposit");
            addTransaction.Show();
        }

        private void ViewAcctBalBtn_Click(object sender, EventArgs e)
        {
            ViewAccountBalancesForm viewAccountBalances = new ViewAccountBalancesForm();
            viewAccountBalances.Show();
        }
    }
    public static class ImpInfo
    {
        public static string username = "";
        public static int userId = -1;
        public static int maxChar = 50;
    }
}
