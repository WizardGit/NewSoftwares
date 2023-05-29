namespace Budgette
{
    partial class AddAccountForm
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
            this.components = new System.ComponentModel.Container();
            this.tblAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.Bank = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceTxtBox = new System.Windows.Forms.TextBox();
            this.bankComboBox = new System.Windows.Forms.ComboBox();
            this.tblAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblAccountTableAdapter();
            this.tblAccountBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAccountBindingSource1
            // 
            this.tblAccountBindingSource1.DataMember = "tblAccount";
            this.tblAccountBindingSource1.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bank Account Name";
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Location = new System.Drawing.Point(79, 15);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(32, 13);
            this.Bank.TabIndex = 11;
            this.Bank.Text = "Bank";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(122, 114);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(122, 36);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(121, 20);
            this.nameTxtBox.TabIndex = 9;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(122, 85);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(121, 23);
            this.createAccountBtn.TabIndex = 7;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Balance";
            // 
            // balanceTxtBox
            // 
            this.balanceTxtBox.Location = new System.Drawing.Point(122, 59);
            this.balanceTxtBox.Name = "balanceTxtBox";
            this.balanceTxtBox.Size = new System.Drawing.Size(121, 20);
            this.balanceTxtBox.TabIndex = 15;
            // 
            // bankComboBox
            // 
            this.bankComboBox.FormattingEnabled = true;
            this.bankComboBox.Location = new System.Drawing.Point(122, 12);
            this.bankComboBox.Name = "bankComboBox";
            this.bankComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankComboBox.TabIndex = 16;
            // 
            // tblAccountBindingSource
            // 
            this.tblAccountBindingSource.DataMember = "tblAccount";
            this.tblAccountBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // tblAccountTableAdapter
            // 
            this.tblAccountTableAdapter.ClearBeforeFill = true;
            // 
            // tblAccountBindingSource2
            // 
            this.tblAccountBindingSource2.DataMember = "tblAccount";
            this.tblAccountBindingSource2.DataSource = this.mainDatabaseDataSet;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 151);
            this.Controls.Add(this.bankComboBox);
            this.Controls.Add(this.balanceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.createAccountBtn);
            this.Name = "AddAccountForm";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Bank;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button createAccountBtn;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblAccountBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balanceTxtBox;
        private System.Windows.Forms.BindingSource tblAccountBindingSource1;
        private MainDatabaseDataSetTableAdapters.tblAccountTableAdapter tblAccountTableAdapter;
        private System.Windows.Forms.ComboBox bankComboBox;
        private System.Windows.Forms.BindingSource tblAccountBindingSource2;
    }
}