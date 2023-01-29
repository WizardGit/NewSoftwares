namespace Budgette
{
    partial class BackupsForm
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
            this.createBackupBtn = new System.Windows.Forms.Button();
            this.restoreBackupBtn = new System.Windows.Forms.Button();
            this.databaseBackupComboBox = new System.Windows.Forms.ComboBox();
            this.exceptionPlaceholder = new System.Windows.Forms.Label();
            this.backupNameTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.removeDBBackupBtn = new System.Windows.Forms.Button();
            this.removeDBBackupComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createBackupBtn
            // 
            this.createBackupBtn.Location = new System.Drawing.Point(12, 12);
            this.createBackupBtn.Name = "createBackupBtn";
            this.createBackupBtn.Size = new System.Drawing.Size(113, 53);
            this.createBackupBtn.TabIndex = 13;
            this.createBackupBtn.Text = "Create Backup of Database";
            this.createBackupBtn.UseVisualStyleBackColor = true;
            this.createBackupBtn.Click += new System.EventHandler(this.createBackupBtn_Click);
            // 
            // restoreBackupBtn
            // 
            this.restoreBackupBtn.Location = new System.Drawing.Point(12, 71);
            this.restoreBackupBtn.Name = "restoreBackupBtn";
            this.restoreBackupBtn.Size = new System.Drawing.Size(113, 53);
            this.restoreBackupBtn.TabIndex = 14;
            this.restoreBackupBtn.Text = "Restore Backup of Database";
            this.restoreBackupBtn.UseVisualStyleBackColor = true;
            this.restoreBackupBtn.Click += new System.EventHandler(this.restoreBackupBtn_Click);
            // 
            // databaseBackupComboBox
            // 
            this.databaseBackupComboBox.FormattingEnabled = true;
            this.databaseBackupComboBox.Location = new System.Drawing.Point(146, 71);
            this.databaseBackupComboBox.Name = "databaseBackupComboBox";
            this.databaseBackupComboBox.Size = new System.Drawing.Size(288, 21);
            this.databaseBackupComboBox.TabIndex = 15;
            // 
            // exceptionPlaceholder
            // 
            this.exceptionPlaceholder.AutoSize = true;
            this.exceptionPlaceholder.Location = new System.Drawing.Point(261, 214);
            this.exceptionPlaceholder.Name = "exceptionPlaceholder";
            this.exceptionPlaceholder.Size = new System.Drawing.Size(113, 13);
            this.exceptionPlaceholder.TabIndex = 16;
            this.exceptionPlaceholder.Text = "Exception Placeholder";
            // 
            // backupNameTxtBox
            // 
            this.backupNameTxtBox.Location = new System.Drawing.Point(146, 12);
            this.backupNameTxtBox.Name = "backupNameTxtBox";
            this.backupNameTxtBox.Size = new System.Drawing.Size(288, 20);
            this.backupNameTxtBox.TabIndex = 17;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(24, 187);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(113, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // removeDBBackupBtn
            // 
            this.removeDBBackupBtn.Location = new System.Drawing.Point(12, 128);
            this.removeDBBackupBtn.Name = "removeDBBackupBtn";
            this.removeDBBackupBtn.Size = new System.Drawing.Size(113, 53);
            this.removeDBBackupBtn.TabIndex = 19;
            this.removeDBBackupBtn.Text = "Remove Backup of Database";
            this.removeDBBackupBtn.UseVisualStyleBackColor = true;
            this.removeDBBackupBtn.Click += new System.EventHandler(this.removeDBBackupBtn_Click);
            // 
            // removeDBBackupComboBox
            // 
            this.removeDBBackupComboBox.FormattingEnabled = true;
            this.removeDBBackupComboBox.Location = new System.Drawing.Point(146, 128);
            this.removeDBBackupComboBox.Name = "removeDBBackupComboBox";
            this.removeDBBackupComboBox.Size = new System.Drawing.Size(288, 21);
            this.removeDBBackupComboBox.TabIndex = 20;
            // 
            // BackupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 310);
            this.Controls.Add(this.removeDBBackupComboBox);
            this.Controls.Add(this.removeDBBackupBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.backupNameTxtBox);
            this.Controls.Add(this.exceptionPlaceholder);
            this.Controls.Add(this.databaseBackupComboBox);
            this.Controls.Add(this.restoreBackupBtn);
            this.Controls.Add(this.createBackupBtn);
            this.Name = "BackupsForm";
            this.Text = "BackupsForm";
            this.Load += new System.EventHandler(this.BackupsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBackupBtn;
        private System.Windows.Forms.Button restoreBackupBtn;
        private System.Windows.Forms.ComboBox databaseBackupComboBox;
        private System.Windows.Forms.Label exceptionPlaceholder;
        private System.Windows.Forms.TextBox backupNameTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button removeDBBackupBtn;
        private System.Windows.Forms.ComboBox removeDBBackupComboBox;
    }
}