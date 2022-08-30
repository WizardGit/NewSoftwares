
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UsernameBtn = new System.Windows.Forms.Button();
            this.DisplayAccountLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.AddAccountBtn = new System.Windows.Forms.Button();
            this.DisplayTransLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(128, 23);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 0;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(35, 26);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(58, 13);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username:";
            // 
            // UsernameBtn
            // 
            this.UsernameBtn.Location = new System.Drawing.Point(243, 21);
            this.UsernameBtn.Name = "UsernameBtn";
            this.UsernameBtn.Size = new System.Drawing.Size(75, 23);
            this.UsernameBtn.TabIndex = 5;
            this.UsernameBtn.Text = "Load";
            this.UsernameBtn.UseVisualStyleBackColor = true;
            this.UsernameBtn.Click += new System.EventHandler(this.UsernameBtn_Click);
            // 
            // DisplayAccountLbl
            // 
            this.DisplayAccountLbl.AutoSize = true;
            this.DisplayAccountLbl.Location = new System.Drawing.Point(89, 76);
            this.DisplayAccountLbl.Name = "DisplayAccountLbl";
            this.DisplayAccountLbl.Size = new System.Drawing.Size(57, 13);
            this.DisplayAccountLbl.TabIndex = 6;
            this.DisplayAccountLbl.Text = "Placement";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(335, 152);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddAccountBtn
            // 
            this.AddAccountBtn.Location = new System.Drawing.Point(128, 215);
            this.AddAccountBtn.Name = "AddAccountBtn";
            this.AddAccountBtn.Size = new System.Drawing.Size(128, 23);
            this.AddAccountBtn.TabIndex = 8;
            this.AddAccountBtn.Text = "Add Account";
            this.AddAccountBtn.UseVisualStyleBackColor = true;
            this.AddAccountBtn.Click += new System.EventHandler(this.AddAccountBtn_Click);
            // 
            // DisplayTransLbl
            // 
            this.DisplayTransLbl.AutoSize = true;
            this.DisplayTransLbl.Location = new System.Drawing.Point(459, 76);
            this.DisplayTransLbl.Name = "DisplayTransLbl";
            this.DisplayTransLbl.Size = new System.Drawing.Size(57, 13);
            this.DisplayTransLbl.TabIndex = 9;
            this.DisplayTransLbl.Text = "Placement";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(243, 71);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 327);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DisplayTransLbl);
            this.Controls.Add(this.AddAccountBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.DisplayAccountLbl);
            this.Controls.Add(this.UsernameBtn);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.usernameTxt);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Button UsernameBtn;
        private System.Windows.Forms.Label DisplayAccountLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button AddAccountBtn;
        private System.Windows.Forms.Label DisplayTransLbl;
        private System.Windows.Forms.Button SaveBtn;
    }
}

