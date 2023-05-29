namespace Budgette
{
    partial class ViewAccountBalancesForm
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
            this.BankComboBox = new System.Windows.Forms.ComboBox();
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetAcctBtn = new System.Windows.Forms.Button();
            this.RtnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayBalanceTxt = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new Budgette.MainDatabaseDataSetTableAdapters.TableAdapterManager();
            this.WithdrawnMonthTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DepositMonthTxt = new System.Windows.Forms.Label();
            this.tblAccountDataGridView = new System.Windows.Forms.DataGridView();
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.tblAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblAccountTableAdapter();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankComboBox
            // 
            this.BankComboBox.FormattingEnabled = true;
            this.BankComboBox.Location = new System.Drawing.Point(87, 19);
            this.BankComboBox.Name = "BankComboBox";
            this.BankComboBox.Size = new System.Drawing.Size(121, 21);
            this.BankComboBox.TabIndex = 0;
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(87, 45);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.AccountComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank";
            // 
            // GetAcctBtn
            // 
            this.GetAcctBtn.Location = new System.Drawing.Point(12, 77);
            this.GetAcctBtn.Name = "GetAcctBtn";
            this.GetAcctBtn.Size = new System.Drawing.Size(75, 23);
            this.GetAcctBtn.TabIndex = 3;
            this.GetAcctBtn.Text = "Get Account";
            this.GetAcctBtn.UseVisualStyleBackColor = true;
            this.GetAcctBtn.Click += new System.EventHandler(this.GetAcctBtn_Click);
            // 
            // RtnBtn
            // 
            this.RtnBtn.Location = new System.Drawing.Point(12, 277);
            this.RtnBtn.Name = "RtnBtn";
            this.RtnBtn.Size = new System.Drawing.Size(121, 31);
            this.RtnBtn.TabIndex = 4;
            this.RtnBtn.Text = "Go Back";
            this.RtnBtn.UseVisualStyleBackColor = true;
            this.RtnBtn.Click += new System.EventHandler(this.RtnBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Balance:";
            // 
            // DisplayBalanceTxt
            // 
            this.DisplayBalanceTxt.AutoSize = true;
            this.DisplayBalanceTxt.Location = new System.Drawing.Point(159, 77);
            this.DisplayBalanceTxt.Name = "DisplayBalanceTxt";
            this.DisplayBalanceTxt.Size = new System.Drawing.Size(49, 13);
            this.DisplayBalanceTxt.TabIndex = 7;
            this.DisplayBalanceTxt.Text = "--------------";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblAccountTableAdapter = this.tblAccountTableAdapter;
            this.tableAdapterManager1.tblBankTableAdapter = null;
            this.tableAdapterManager1.tblBucketTableAdapter = null;
            this.tableAdapterManager1.tblTransactionTableAdapter = null;
            this.tableAdapterManager1.tblUserTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Budgette.MainDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // WithdrawnMonthTxt
            // 
            this.WithdrawnMonthTxt.AutoSize = true;
            this.WithdrawnMonthTxt.Location = new System.Drawing.Point(6, 52);
            this.WithdrawnMonthTxt.Name = "WithdrawnMonthTxt";
            this.WithdrawnMonthTxt.Size = new System.Drawing.Size(152, 13);
            this.WithdrawnMonthTxt.TabIndex = 8;
            this.WithdrawnMonthTxt.Text = "Money Withdrawn This Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Money Deposited This Month: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "--------------";
            // 
            // DepositMonthTxt
            // 
            this.DepositMonthTxt.AutoSize = true;
            this.DepositMonthTxt.Location = new System.Drawing.Point(164, 23);
            this.DepositMonthTxt.Name = "DepositMonthTxt";
            this.DepositMonthTxt.Size = new System.Drawing.Size(49, 13);
            this.DepositMonthTxt.TabIndex = 11;
            this.DepositMonthTxt.Text = "--------------";
            // 
            // tblAccountDataGridView
            // 
            this.tblAccountDataGridView.AutoGenerateColumns = false;
            this.tblAccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn,
            this.bankDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.tblAccountDataGridView.DataSource = this.tblAccountBindingSource;
            this.tblAccountDataGridView.Location = new System.Drawing.Point(12, 121);
            this.tblAccountDataGridView.Name = "tblAccountDataGridView";
            this.tblAccountDataGridView.Size = new System.Drawing.Size(628, 150);
            this.tblAccountDataGridView.TabIndex = 14;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.WithdrawnMonthTxt);
            this.groupBox1.Controls.Add(this.DepositMonthTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(232, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 83);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // ViewAccountBalancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblAccountDataGridView);
            this.Controls.Add(this.DisplayBalanceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtnBtn);
            this.Controls.Add(this.GetAcctBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountComboBox);
            this.Controls.Add(this.BankComboBox);
            this.Name = "ViewAccountBalancesForm";
            this.Text = "ViewAccountBalancesForm";
            this.Load += new System.EventHandler(this.ViewAccountBalancesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BankComboBox;
        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetAcctBtn;
        private System.Windows.Forms.Button RtnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisplayBalanceTxt;
        private MainDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label WithdrawnMonthTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DepositMonthTxt;
        private MainDatabaseDataSetTableAdapters.tblAccountTableAdapter tblAccountTableAdapter;
        private System.Windows.Forms.DataGridView tblAccountDataGridView;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblAccountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}