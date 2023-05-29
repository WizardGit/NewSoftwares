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
    public partial class ViewAccountBalancesForm : Form
    {
        public ViewAccountBalancesForm()
        {
            InitializeComponent();
        }

        private void ViewAccountBalancesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.tblAccount' table. You can move, or remove it, as needed.
            this.tblAccountTableAdapter.Fill(this.mainDatabaseDataSet.tblAccount);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select Name from tblBank where UserId= '" + ImpInfo.userId + "' order by Name asc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    BankComboBox.Items.Add(string.Format("{0}", reader["Name"]));
            }

            command = new SqlCommand("Select Name from tblAccount where UserId= '" + ImpInfo.userId + "' order by Name asc", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    AccountComboBox.Items.Add(string.Format("{0}", reader["Name"]));
            }

            con.Close();
        }        

        private void GetAcctBtn_Click(object sender, EventArgs e)
        {
            GetBalance();
            GetMonthDeposit();
            GetMonthWithdraw();
            Debug.WriteLine("done");
        }

        private void GetBalance()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select balance from tblAccount where Bank = '" + BankComboBox.Text + "' and Name = '" + AccountComboBox.Text + "'", con);
            string strAccountBalance = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                    strAccountBalance = string.Format("{0}", reader["Balance"]);
            }
            DisplayBalanceTxt.Text = strAccountBalance;

            con.Close();
        }

        private void GetMonthDeposit()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select balance from tblTransaction where month(Date) = '" + DateTime.Today.Month + "' and BankTo = '" + BankComboBox.Text + "' and AccountTo = '" + AccountComboBox.Text + "'", con);
            decimal decMonthBalance = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Decimal.TryParse(string.Format("{0}", reader["Balance"]), out decimal tempBal);
                    decMonthBalance += tempBal;
                }                    
            }
            DepositMonthTxt.Text = decMonthBalance.ToString();
            con.Close();
        }

        private void GetMonthWithdraw()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select balance from tblTransaction where month(Date) = '" + DateTime.Today.Month + "' and BankFrom = '" + BankComboBox.Text + "' and AccountFrom = '" + AccountComboBox.Text + "'", con);
            decimal decMonthBalance = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Decimal.TryParse(string.Format("{0}", reader["Balance"]), out decimal tempBal);
                    decMonthBalance += tempBal;
                }
            }
            WithdrawMonthTxt.Text = decMonthBalance.ToString();
            con.Close();
        }

        private void RtnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
