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
            this.quitBtn.Location = new System.Drawing.Point(13, 71);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(110, 23);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "QUIT";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.addBankAccountBtn);
            this.Controls.Add(this.addUserBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button addBankAccountBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}

