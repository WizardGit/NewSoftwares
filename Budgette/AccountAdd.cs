﻿using System;
using System.Windows.Forms;

namespace Budgette
{
    public partial class AccountAdd : Form
    {
        public AccountAdd()
        {
            InitializeComponent();
        }

        private void AccountCreateBtn_Click(object sender, EventArgs e)
        {
            string str = AccountTxt.Text;
            if (MainForm.MainFormAccounts.AddAccount(AccountTxt.Text) == false)
                MessageBox.Show("Cannot Create an account with the same name as a pre-existing account.");            
            this.Close();
        }

        private void CancelAccountBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.tblAcct' table. You can move, or remove it, as needed.
            this.tblAcctTableAdapter.Fill(this.database1DataSet.tblAcct);

        }
    }
}
