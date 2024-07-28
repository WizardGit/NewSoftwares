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
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.AddBankAccountBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.AddBucketBtn = new System.Windows.Forms.Button();
            this.AddTransactionBtn = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.AddBankBtn = new System.Windows.Forms.Button();
            this.DbBackupBtn = new System.Windows.Forms.Button();
            this.MakeDepositBtn = new System.Windows.Forms.Button();
            this.MakeTransferBtn = new System.Windows.Forms.Button();
            this.MakeWithdrawBtn = new System.Windows.Forms.Button();
            this.ViewAcctBalBtn = new System.Windows.Forms.Button();
            this.TransactionsGrpBox = new System.Windows.Forms.GroupBox();
            this.UsrConfigGrpBox = new System.Windows.Forms.GroupBox();
            this.LoginGrpBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TransactionsGrpBox.SuspendLayout();
            this.UsrConfigGrpBox.SuspendLayout();
            this.LoginGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(7, 19);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(111, 23);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // AddBankAccountBtn
            // 
            this.AddBankAccountBtn.Location = new System.Drawing.Point(7, 48);
            this.AddBankAccountBtn.Name = "AddBankAccountBtn";
            this.AddBankAccountBtn.Size = new System.Drawing.Size(111, 23);
            this.AddBankAccountBtn.TabIndex = 1;
            this.AddBankAccountBtn.Text = "Add Bank Account";
            this.AddBankAccountBtn.UseVisualStyleBackColor = true;
            this.AddBankAccountBtn.Click += new System.EventHandler(this.AddBankAccountBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(13, 258);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(110, 23);
            this.QuitBtn.TabIndex = 2;
            this.QuitBtn.Text = "QUIT";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // AddBucketBtn
            // 
            this.AddBucketBtn.Location = new System.Drawing.Point(124, 19);
            this.AddBucketBtn.Name = "AddBucketBtn";
            this.AddBucketBtn.Size = new System.Drawing.Size(111, 23);
            this.AddBucketBtn.TabIndex = 3;
            this.AddBucketBtn.Text = "Add Bucket";
            this.AddBucketBtn.UseVisualStyleBackColor = true;
            this.AddBucketBtn.Click += new System.EventHandler(this.AddBucketBtn_Click);
            // 
            // AddTransactionBtn
            // 
            this.AddTransactionBtn.Location = new System.Drawing.Point(127, 44);
            this.AddTransactionBtn.Name = "AddTransactionBtn";
            this.AddTransactionBtn.Size = new System.Drawing.Size(111, 23);
            this.AddTransactionBtn.TabIndex = 4;
            this.AddTransactionBtn.Text = "Add Transaction";
            this.AddTransactionBtn.UseVisualStyleBackColor = true;
            this.AddTransactionBtn.Click += new System.EventHandler(this.AddTransactionBtn_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(82, 19);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(82, 59);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 8;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(82, 87);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(100, 23);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(11, 116);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(45, 13);
            this.userLbl.TabIndex = 10;
            this.userLbl.Text = "User is: ";
            // 
            // AddBankBtn
            // 
            this.AddBankBtn.Location = new System.Drawing.Point(124, 77);
            this.AddBankBtn.Name = "AddBankBtn";
            this.AddBankBtn.Size = new System.Drawing.Size(111, 23);
            this.AddBankBtn.TabIndex = 11;
            this.AddBankBtn.Text = "Add Bank";
            this.AddBankBtn.UseVisualStyleBackColor = true;
            this.AddBankBtn.Click += new System.EventHandler(this.AddBankBtn_Click);
            // 
            // DbBackupBtn
            // 
            this.DbBackupBtn.Location = new System.Drawing.Point(7, 77);
            this.DbBackupBtn.Name = "DbBackupBtn";
            this.DbBackupBtn.Size = new System.Drawing.Size(111, 23);
            this.DbBackupBtn.TabIndex = 12;
            this.DbBackupBtn.Text = "Backups";
            this.DbBackupBtn.UseVisualStyleBackColor = true;
            this.DbBackupBtn.Click += new System.EventHandler(this.DbBackupBtn_Click);
            // 
            // MakeDepositBtn
            // 
            this.MakeDepositBtn.Location = new System.Drawing.Point(9, 44);
            this.MakeDepositBtn.Name = "MakeDepositBtn";
            this.MakeDepositBtn.Size = new System.Drawing.Size(111, 23);
            this.MakeDepositBtn.TabIndex = 13;
            this.MakeDepositBtn.Text = "Make Deposit";
            this.MakeDepositBtn.UseVisualStyleBackColor = true;
            this.MakeDepositBtn.Click += new System.EventHandler(this.MakeDepositBtn_Click);
            // 
            // MakeTransferBtn
            // 
            this.MakeTransferBtn.Location = new System.Drawing.Point(127, 19);
            this.MakeTransferBtn.Name = "MakeTransferBtn";
            this.MakeTransferBtn.Size = new System.Drawing.Size(111, 23);
            this.MakeTransferBtn.TabIndex = 14;
            this.MakeTransferBtn.Text = "Make Transfer";
            this.MakeTransferBtn.UseVisualStyleBackColor = true;
            this.MakeTransferBtn.Click += new System.EventHandler(this.MakeTransferBtn_Click);
            // 
            // MakeWithdrawBtn
            // 
            this.MakeWithdrawBtn.Location = new System.Drawing.Point(9, 19);
            this.MakeWithdrawBtn.Name = "MakeWithdrawBtn";
            this.MakeWithdrawBtn.Size = new System.Drawing.Size(111, 23);
            this.MakeWithdrawBtn.TabIndex = 15;
            this.MakeWithdrawBtn.Text = "Make Withdrawal";
            this.MakeWithdrawBtn.UseVisualStyleBackColor = true;
            this.MakeWithdrawBtn.Click += new System.EventHandler(this.MakeWithdrawBtn_Click);
            // 
            // ViewAcctBalBtn
            // 
            this.ViewAcctBalBtn.Location = new System.Drawing.Point(12, 216);
            this.ViewAcctBalBtn.Name = "ViewAcctBalBtn";
            this.ViewAcctBalBtn.Size = new System.Drawing.Size(111, 36);
            this.ViewAcctBalBtn.TabIndex = 16;
            this.ViewAcctBalBtn.Text = "View Account Balances";
            this.ViewAcctBalBtn.UseVisualStyleBackColor = true;
            this.ViewAcctBalBtn.Click += new System.EventHandler(this.ViewAcctBalBtn_Click);
            // 
            // TransactionsGrpBox
            // 
            this.TransactionsGrpBox.Controls.Add(this.MakeTransferBtn);
            this.TransactionsGrpBox.Controls.Add(this.AddTransactionBtn);
            this.TransactionsGrpBox.Controls.Add(this.MakeWithdrawBtn);
            this.TransactionsGrpBox.Controls.Add(this.MakeDepositBtn);
            this.TransactionsGrpBox.Location = new System.Drawing.Point(12, 12);
            this.TransactionsGrpBox.Name = "TransactionsGrpBox";
            this.TransactionsGrpBox.Size = new System.Drawing.Size(253, 79);
            this.TransactionsGrpBox.TabIndex = 17;
            this.TransactionsGrpBox.TabStop = false;
            this.TransactionsGrpBox.Text = "Transactions";
            // 
            // UsrConfigGrpBox
            // 
            this.UsrConfigGrpBox.Controls.Add(this.AddBucketBtn);
            this.UsrConfigGrpBox.Controls.Add(this.AddUserBtn);
            this.UsrConfigGrpBox.Controls.Add(this.AddBankAccountBtn);
            this.UsrConfigGrpBox.Controls.Add(this.DbBackupBtn);
            this.UsrConfigGrpBox.Controls.Add(this.AddBankBtn);
            this.UsrConfigGrpBox.Location = new System.Drawing.Point(12, 99);
            this.UsrConfigGrpBox.Name = "UsrConfigGrpBox";
            this.UsrConfigGrpBox.Size = new System.Drawing.Size(253, 111);
            this.UsrConfigGrpBox.TabIndex = 18;
            this.UsrConfigGrpBox.TabStop = false;
            this.UsrConfigGrpBox.Text = "User Configuration";
            // 
            // LoginGrpBox
            // 
            this.LoginGrpBox.Controls.Add(this.usernameTxtBox);
            this.LoginGrpBox.Controls.Add(this.label1);
            this.LoginGrpBox.Controls.Add(this.label2);
            this.LoginGrpBox.Controls.Add(this.passwordTxtBox);
            this.LoginGrpBox.Controls.Add(this.userLbl);
            this.LoginGrpBox.Controls.Add(this.LoginBtn);
            this.LoginGrpBox.Location = new System.Drawing.Point(286, 12);
            this.LoginGrpBox.Name = "LoginGrpBox";
            this.LoginGrpBox.Size = new System.Drawing.Size(200, 142);
            this.LoginGrpBox.TabIndex = 19;
            this.LoginGrpBox.TabStop = false;
            this.LoginGrpBox.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Budgette.Properties.Resources.NeighborhoodWatch;
            this.pictureBox1.Location = new System.Drawing.Point(286, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginGrpBox);
            this.Controls.Add(this.UsrConfigGrpBox);
            this.Controls.Add(this.TransactionsGrpBox);
            this.Controls.Add(this.ViewAcctBalBtn);
            this.Controls.Add(this.QuitBtn);
            this.Name = "MainForm";
            this.Text = "Budgette Software";
            this.TransactionsGrpBox.ResumeLayout(false);
            this.UsrConfigGrpBox.ResumeLayout(false);
            this.LoginGrpBox.ResumeLayout(false);
            this.LoginGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button AddBankAccountBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button AddBucketBtn;
        private System.Windows.Forms.Button AddTransactionBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Button AddBankBtn;
        private System.Windows.Forms.Button DbBackupBtn;
        private System.Windows.Forms.Button MakeDepositBtn;
        private System.Windows.Forms.Button MakeTransferBtn;
        private System.Windows.Forms.Button MakeWithdrawBtn;
        private System.Windows.Forms.Button ViewAcctBalBtn;
        private System.Windows.Forms.GroupBox TransactionsGrpBox;
        private System.Windows.Forms.GroupBox UsrConfigGrpBox;
        private System.Windows.Forms.GroupBox LoginGrpBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

