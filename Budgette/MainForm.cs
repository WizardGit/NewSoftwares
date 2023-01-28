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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserform = new AddUserForm();
            addUserform.Show();            
        }

        private void addBankAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccount = new AddAccountForm();
            addAccount.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBucketBtn_Click(object sender, EventArgs e)
        {
            AddBucketForm addBucket = new AddBucketForm();
            addBucket.Show();
        }

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransaction = new AddTransactionForm();
            addTransaction.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
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

        private void addBankBtn_Click(object sender, EventArgs e)
        {
            AddBankForm addBank = new AddBankForm();
            addBank.Show();
        }
    }
    public static class ImpInfo
    {
        public static string username = "";
        public static int userId = -1;
        public static int maxChar = 50;
    }
}
