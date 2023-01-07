using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Budgette
{
    [System.Serializable]
    public partial class MainForm : Form
    {
        public static Accounts MainFormAccounts;
        public static Transactions MainFormTransactions;
        private InfoSave info;
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.tblAcct' table. You can move, or remove it, as needed.
            this.tblAcctTableAdapter.Fill(this.database1DataSet.tblAcct);
            MainFormAccounts = new Accounts();
            MainFormTransactions = new Transactions();
            DisplayResults();
        }

        private void UsernameBtn_Click(object sender, EventArgs e)
        {
            info = new InfoSave(usernameTxt.Text);
            MainFormAccounts = info.accounts;
            MainFormTransactions = info.transactions;            
        }

        private void DisplayResults()
        {
            DisplayAccountLbl.Text = MainFormAccounts.ReturnAllAccountInfo();
            DisplayTransLbl.Text = MainFormTransactions.ReturnAllTransactionInfo();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            AccountAdd accountAddForm = new AccountAdd();
            accountAddForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            info.accounts = MainFormAccounts;
            info.transactions = MainFormTransactions;
            info.SaveUser();
            DisplayResults();
        }

        private void showTableDataBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            con.Open();
            String str = "insert into tblAcct(Id,street) values(5,'Buck')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();

            AccountAdd frm2 = new AccountAdd();
            this.Hide();
            frm2.Show();
        }
    }
}
