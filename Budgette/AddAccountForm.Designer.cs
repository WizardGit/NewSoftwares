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
            this.tblAccountDataGridView = new System.Windows.Forms.DataGridView();
            this.tblAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.Bank = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.bankTxtBox = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceTxtBox = new System.Windows.Forms.TextBox();
            this.tblAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblAccountTableAdapter();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAccountDataGridView
            // 
            this.tblAccountDataGridView.AutoGenerateColumns = false;
            this.tblAccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn,
            this.bankDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.tblAccountDataGridView.DataSource = this.tblAccountBindingSource1;
            this.tblAccountDataGridView.Location = new System.Drawing.Point(208, 63);
            this.tblAccountDataGridView.Name = "tblAccountDataGridView";
            this.tblAccountDataGridView.Size = new System.Drawing.Size(383, 150);
            this.tblAccountDataGridView.TabIndex = 13;
            // 
            // tblAccountBindingSource
            // 
            this.tblAccountBindingSource.DataMember = "tblAccount";
            this.tblAccountBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bank Account Name";
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Location = new System.Drawing.Point(12, 9);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(32, 13);
            this.Bank.TabIndex = 11;
            this.Bank.Text = "Bank";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(70, 153);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(110, 25);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 9;
            // 
            // bankTxtBox
            // 
            this.bankTxtBox.Location = new System.Drawing.Point(50, 2);
            this.bankTxtBox.Name = "bankTxtBox";
            this.bankTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bankTxtBox.TabIndex = 8;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(70, 124);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(94, 23);
            this.createAccountBtn.TabIndex = 7;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Balance";
            // 
            // balanceTxtBox
            // 
            this.balanceTxtBox.Location = new System.Drawing.Point(64, 48);
            this.balanceTxtBox.Name = "balanceTxtBox";
            this.balanceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTxtBox.TabIndex = 15;
            // 
            // tblAccountBindingSource1
            // 
            this.tblAccountBindingSource1.DataMember = "tblAccount";
            this.tblAccountBindingSource1.DataSource = this.mainDatabaseDataSet;
            // 
            // tblAccountTableAdapter
            // 
            this.tblAccountTableAdapter.ClearBeforeFill = true;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            // 
            // bankDataGridViewTextBoxColumn
            // 
            this.bankDataGridViewTextBoxColumn.DataPropertyName = "Bank";
            this.bankDataGridViewTextBoxColumn.HeaderText = "Bank";
            this.bankDataGridViewTextBoxColumn.Name = "bankDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 270);
            this.Controls.Add(this.balanceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblAccountDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.bankTxtBox);
            this.Controls.Add(this.createAccountBtn);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblAccountDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Bank;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox bankTxtBox;
        private System.Windows.Forms.Button createAccountBtn;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblAccountBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balanceTxtBox;
        private System.Windows.Forms.BindingSource tblAccountBindingSource1;
        private MainDatabaseDataSetTableAdapters.tblAccountTableAdapter tblAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}