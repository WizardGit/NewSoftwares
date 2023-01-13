using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Close();
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
    }
}
