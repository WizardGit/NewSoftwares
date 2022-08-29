
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
            this.displayLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
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
            this.UsernameBtn.Text = "Enter";
            this.UsernameBtn.UseVisualStyleBackColor = true;
            this.UsernameBtn.Click += new System.EventHandler(this.UsernameBtn_Click);
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Location = new System.Drawing.Point(89, 76);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(57, 13);
            this.displayLbl.TabIndex = 6;
            this.displayLbl.Text = "Placement";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 327);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.displayLbl);
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
        private System.Windows.Forms.Label displayLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}

