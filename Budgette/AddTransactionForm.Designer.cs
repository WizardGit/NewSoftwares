namespace Budgette
{
    partial class AddTransactionForm
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
            this.tblTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.accountFromTxtBox = new System.Windows.Forms.TextBox();
            this.bankNameTxtBox = new System.Windows.Forms.TextBox();
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.bucketToTxtBox = new System.Windows.Forms.TextBox();
            this.bucketFromTxtBox = new System.Windows.Forms.TextBox();
            this.accountToTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTransactionDataGridView
            // 
            this.tblTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTransactionDataGridView.Location = new System.Drawing.Point(234, 7);
            this.tblTransactionDataGridView.Name = "tblTransactionDataGridView";
            this.tblTransactionDataGridView.Size = new System.Drawing.Size(383, 150);
            this.tblTransactionDataGridView.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Account From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bank";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(128, 167);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // accountFromTxtBox
            // 
            this.accountFromTxtBox.Location = new System.Drawing.Point(103, 33);
            this.accountFromTxtBox.Name = "accountFromTxtBox";
            this.accountFromTxtBox.Size = new System.Drawing.Size(100, 20);
            this.accountFromTxtBox.TabIndex = 9;
            // 
            // bankNameTxtBox
            // 
            this.bankNameTxtBox.Location = new System.Drawing.Point(103, 7);
            this.bankNameTxtBox.Name = "bankNameTxtBox";
            this.bankNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bankNameTxtBox.TabIndex = 8;
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Location = new System.Drawing.Point(12, 167);
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Size = new System.Drawing.Size(110, 23);
            this.addTransactionBtn.TabIndex = 7;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bucket To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bucket From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Account To";
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(103, 137);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.amountTxtBox.TabIndex = 19;
            // 
            // bucketToTxtBox
            // 
            this.bucketToTxtBox.Location = new System.Drawing.Point(103, 111);
            this.bucketToTxtBox.Name = "bucketToTxtBox";
            this.bucketToTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bucketToTxtBox.TabIndex = 20;
            // 
            // bucketFromTxtBox
            // 
            this.bucketFromTxtBox.Location = new System.Drawing.Point(103, 85);
            this.bucketFromTxtBox.Name = "bucketFromTxtBox";
            this.bucketFromTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bucketFromTxtBox.TabIndex = 21;
            // 
            // accountToTxtBox
            // 
            this.accountToTxtBox.Location = new System.Drawing.Point(103, 59);
            this.accountToTxtBox.Name = "accountToTxtBox";
            this.accountToTxtBox.Size = new System.Drawing.Size(100, 20);
            this.accountToTxtBox.TabIndex = 22;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 322);
            this.Controls.Add(this.accountToTxtBox);
            this.Controls.Add(this.bucketFromTxtBox);
            this.Controls.Add(this.bucketToTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblTransactionDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.accountFromTxtBox);
            this.Controls.Add(this.bankNameTxtBox);
            this.Controls.Add(this.addTransactionBtn);
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTransactionDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox accountFromTxtBox;
        private System.Windows.Forms.TextBox bankNameTxtBox;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.TextBox bucketToTxtBox;
        private System.Windows.Forms.TextBox bucketFromTxtBox;
        private System.Windows.Forms.TextBox accountToTxtBox;
    }
}