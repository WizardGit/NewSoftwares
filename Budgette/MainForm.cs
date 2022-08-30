using System;
using System.Windows.Forms;

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
    }
}
