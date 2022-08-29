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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Nothing
        }

        private void UsernameBtn_Click(object sender, EventArgs e)
        {
            InfoSave s = new InfoSave(usernameTxt.Text);
            if (s.accounts.NumOfAccounts() == 0)
            {
                s.accounts.AddAccount("Geoffrey", 10);
                s.SaveUser();
            }

            displayLbl.Text = s.accounts.ReturnAllAccountInfo();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
