namespace Budgette
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addUserBtn = new System.Windows.Forms.Button();
            this.addBankAccountBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.addBucketBtn = new System.Windows.Forms.Button();
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.addBankBtn = new System.Windows.Forms.Button();
            this.dbBackupBtn = new System.Windows.Forms.Button();
            this.makeDepositBtn = new System.Windows.Forms.Button();
            this.makeTransferBtn = new System.Windows.Forms.Button();
            this.makeWithdrawBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(12, 12);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(111, 23);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // addBankAccountBtn
            // 
            this.addBankAccountBtn.Location = new System.Drawing.Point(12, 41);
            this.addBankAccountBtn.Name = "addBankAccountBtn";
            this.addBankAccountBtn.Size = new System.Drawing.Size(111, 23);
            this.addBankAccountBtn.TabIndex = 1;
            this.addBankAccountBtn.Text = "Add Bank Account";
            this.addBankAccountBtn.UseVisualStyleBackColor = true;
            this.addBankAccountBtn.Click += new System.EventHandler(this.addBankAccountBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(12, 215);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(110, 23);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "QUIT";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // addBucketBtn
            // 
            this.addBucketBtn.Location = new System.Drawing.Point(129, 12);
            this.addBucketBtn.Name = "addBucketBtn";
            this.addBucketBtn.Size = new System.Drawing.Size(111, 23);
            this.addBucketBtn.TabIndex = 3;
            this.addBucketBtn.Text = "Add Bucket";
            this.addBucketBtn.UseVisualStyleBackColor = true;
            this.addBucketBtn.Click += new System.EventHandler(this.addBucketBtn_Click);
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Location = new System.Drawing.Point(129, 41);
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Size = new System.Drawing.Size(111, 23);
            this.addTransactionBtn.TabIndex = 4;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(396, 15);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(396, 55);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 8;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(386, 99);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(110, 23);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(393, 157);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(45, 13);
            this.userLbl.TabIndex = 10;
            this.userLbl.Text = "User is: ";
            // 
            // addBankBtn
            // 
            this.addBankBtn.Location = new System.Drawing.Point(129, 70);
            this.addBankBtn.Name = "addBankBtn";
            this.addBankBtn.Size = new System.Drawing.Size(111, 23);
            this.addBankBtn.TabIndex = 11;
            this.addBankBtn.Text = "Add Bank";
            this.addBankBtn.UseVisualStyleBackColor = true;
            this.addBankBtn.Click += new System.EventHandler(this.addBankBtn_Click);
            // 
            // dbBackupBtn
            // 
            this.dbBackupBtn.Location = new System.Drawing.Point(12, 70);
            this.dbBackupBtn.Name = "dbBackupBtn";
            this.dbBackupBtn.Size = new System.Drawing.Size(111, 23);
            this.dbBackupBtn.TabIndex = 12;
            this.dbBackupBtn.Text = "Backups";
            this.dbBackupBtn.UseVisualStyleBackColor = true;
            this.dbBackupBtn.Click += new System.EventHandler(this.dbBackupBtn_Click);
            // 
            // makeDepositBtn
            // 
            this.makeDepositBtn.Location = new System.Drawing.Point(11, 147);
            this.makeDepositBtn.Name = "makeDepositBtn";
            this.makeDepositBtn.Size = new System.Drawing.Size(111, 23);
            this.makeDepositBtn.TabIndex = 13;
            this.makeDepositBtn.Text = "Make Deposit";
            this.makeDepositBtn.UseVisualStyleBackColor = true;
            this.makeDepositBtn.Click += new System.EventHandler(this.makeDepositBtn_Click);
            // 
            // makeTransferBtn
            // 
            this.makeTransferBtn.Location = new System.Drawing.Point(129, 122);
            this.makeTransferBtn.Name = "makeTransferBtn";
            this.makeTransferBtn.Size = new System.Drawing.Size(111, 23);
            this.makeTransferBtn.TabIndex = 14;
            this.makeTransferBtn.Text = "Make Transfer";
            this.makeTransferBtn.UseVisualStyleBackColor = true;
            this.makeTransferBtn.Click += new System.EventHandler(this.makeTransferBtn_Click);
            // 
            // makeWithdrawBtn
            // 
            this.makeWithdrawBtn.Location = new System.Drawing.Point(11, 122);
            this.makeWithdrawBtn.Name = "makeWithdrawBtn";
            this.makeWithdrawBtn.Size = new System.Drawing.Size(111, 23);
            this.makeWithdrawBtn.TabIndex = 15;
            this.makeWithdrawBtn.Text = "Make Withdrawal";
            this.makeWithdrawBtn.UseVisualStyleBackColor = true;
            this.makeWithdrawBtn.Click += new System.EventHandler(this.makeWithdrawBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 250);
            this.Controls.Add(this.makeWithdrawBtn);
            this.Controls.Add(this.makeTransferBtn);
            this.Controls.Add(this.makeDepositBtn);
            this.Controls.Add(this.dbBackupBtn);
            this.Controls.Add(this.addBankBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.addTransactionBtn);
            this.Controls.Add(this.addBucketBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.addBankAccountBtn);
            this.Controls.Add(this.addUserBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button addBankAccountBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button addBucketBtn;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Button addBankBtn;
        private System.Windows.Forms.Button dbBackupBtn;
        private System.Windows.Forms.Button makeDepositBtn;
        private System.Windows.Forms.Button makeTransferBtn;
        private System.Windows.Forms.Button makeWithdrawBtn;
    }
}

