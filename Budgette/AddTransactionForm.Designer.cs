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
            this.components = new System.ComponentModel.Container();
            this.accountFromLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.bucketToLbl = new System.Windows.Forms.Label();
            this.bucketFromLbl = new System.Windows.Forms.Label();
            this.accountToLbl = new System.Windows.Forms.Label();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.bankFromlbl = new System.Windows.Forms.Label();
            this.BankToLbl = new System.Windows.Forms.Label();
            this.accountFromComboBox = new System.Windows.Forms.ComboBox();
            this.bankToComboBox = new System.Windows.Forms.ComboBox();
            this.bankFromComboBox = new System.Windows.Forms.ComboBox();
            this.bucketToComboBox = new System.Windows.Forms.ComboBox();
            this.bucketFromComboBox = new System.Windows.Forms.ComboBox();
            this.accountToComboBox = new System.Windows.Forms.ComboBox();
            this.entityFromTxtBox = new System.Windows.Forms.TextBox();
            this.entityToTxtBox = new System.Windows.Forms.TextBox();
            this.entityFromLbl = new System.Windows.Forms.Label();
            this.entityToLbl = new System.Windows.Forms.Label();
            this.mainDatabaseDataSet1 = new Budgette.MainDatabaseDataSet1();
            this.tblTransactionBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionTableAdapter1 = new Budgette.MainDatabaseDataSet1TableAdapters.tblTransactionTableAdapter();
            this.tblTransactionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.tblTransactionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblTransactionTableAdapter();
            this.tblTransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet2 = new Budgette.MainDatabaseDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountFromLbl
            // 
            this.accountFromLbl.AutoSize = true;
            this.accountFromLbl.Location = new System.Drawing.Point(16, 33);
            this.accountFromLbl.Name = "accountFromLbl";
            this.accountFromLbl.Size = new System.Drawing.Size(73, 13);
            this.accountFromLbl.TabIndex = 12;
            this.accountFromLbl.Text = "Account From";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(141, 363);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Location = new System.Drawing.Point(12, 363);
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Size = new System.Drawing.Size(110, 23);
            this.addTransactionBtn.TabIndex = 7;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(46, 192);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(43, 13);
            this.AmountLbl.TabIndex = 15;
            this.AmountLbl.Text = "Amount";
            // 
            // bucketToLbl
            // 
            this.bucketToLbl.AutoSize = true;
            this.bucketToLbl.Location = new System.Drawing.Point(32, 114);
            this.bucketToLbl.Name = "bucketToLbl";
            this.bucketToLbl.Size = new System.Drawing.Size(57, 13);
            this.bucketToLbl.TabIndex = 16;
            this.bucketToLbl.Text = "Bucket To";
            // 
            // bucketFromLbl
            // 
            this.bucketFromLbl.AutoSize = true;
            this.bucketFromLbl.Location = new System.Drawing.Point(22, 88);
            this.bucketFromLbl.Name = "bucketFromLbl";
            this.bucketFromLbl.Size = new System.Drawing.Size(67, 13);
            this.bucketFromLbl.TabIndex = 17;
            this.bucketFromLbl.Text = "Bucket From";
            // 
            // accountToLbl
            // 
            this.accountToLbl.AutoSize = true;
            this.accountToLbl.Location = new System.Drawing.Point(26, 59);
            this.accountToLbl.Name = "accountToLbl";
            this.accountToLbl.Size = new System.Drawing.Size(63, 13);
            this.accountToLbl.TabIndex = 18;
            this.accountToLbl.Text = "Account To";
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(95, 189);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(121, 20);
            this.amountTxtBox.TabIndex = 19;
            // 
            // bankFromlbl
            // 
            this.bankFromlbl.AutoSize = true;
            this.bankFromlbl.Location = new System.Drawing.Point(31, 145);
            this.bankFromlbl.Name = "bankFromlbl";
            this.bankFromlbl.Size = new System.Drawing.Size(58, 13);
            this.bankFromlbl.TabIndex = 24;
            this.bankFromlbl.Text = "Bank From";
            // 
            // BankToLbl
            // 
            this.BankToLbl.AutoSize = true;
            this.BankToLbl.Location = new System.Drawing.Point(41, 166);
            this.BankToLbl.Name = "BankToLbl";
            this.BankToLbl.Size = new System.Drawing.Size(48, 13);
            this.BankToLbl.TabIndex = 23;
            this.BankToLbl.Text = "Bank To";
            // 
            // accountFromComboBox
            // 
            this.accountFromComboBox.FormattingEnabled = true;
            this.accountFromComboBox.Location = new System.Drawing.Point(95, 30);
            this.accountFromComboBox.Name = "accountFromComboBox";
            this.accountFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountFromComboBox.TabIndex = 25;
            // 
            // bankToComboBox
            // 
            this.bankToComboBox.FormattingEnabled = true;
            this.bankToComboBox.Location = new System.Drawing.Point(95, 163);
            this.bankToComboBox.Name = "bankToComboBox";
            this.bankToComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankToComboBox.TabIndex = 26;
            // 
            // bankFromComboBox
            // 
            this.bankFromComboBox.FormattingEnabled = true;
            this.bankFromComboBox.Location = new System.Drawing.Point(95, 137);
            this.bankFromComboBox.Name = "bankFromComboBox";
            this.bankFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankFromComboBox.TabIndex = 27;
            // 
            // bucketToComboBox
            // 
            this.bucketToComboBox.FormattingEnabled = true;
            this.bucketToComboBox.Location = new System.Drawing.Point(95, 111);
            this.bucketToComboBox.Name = "bucketToComboBox";
            this.bucketToComboBox.Size = new System.Drawing.Size(121, 21);
            this.bucketToComboBox.TabIndex = 28;
            // 
            // bucketFromComboBox
            // 
            this.bucketFromComboBox.FormattingEnabled = true;
            this.bucketFromComboBox.Location = new System.Drawing.Point(95, 85);
            this.bucketFromComboBox.Name = "bucketFromComboBox";
            this.bucketFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.bucketFromComboBox.TabIndex = 29;
            // 
            // accountToComboBox
            // 
            this.accountToComboBox.FormattingEnabled = true;
            this.accountToComboBox.Location = new System.Drawing.Point(95, 56);
            this.accountToComboBox.Name = "accountToComboBox";
            this.accountToComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountToComboBox.TabIndex = 30;
            // 
            // entityFromTxtBox
            // 
            this.entityFromTxtBox.Location = new System.Drawing.Point(95, 241);
            this.entityFromTxtBox.Name = "entityFromTxtBox";
            this.entityFromTxtBox.Size = new System.Drawing.Size(121, 20);
            this.entityFromTxtBox.TabIndex = 32;
            // 
            // entityToTxtBox
            // 
            this.entityToTxtBox.Location = new System.Drawing.Point(95, 215);
            this.entityToTxtBox.Name = "entityToTxtBox";
            this.entityToTxtBox.Size = new System.Drawing.Size(121, 20);
            this.entityToTxtBox.TabIndex = 33;
            // 
            // entityFromLbl
            // 
            this.entityFromLbl.AutoSize = true;
            this.entityFromLbl.Location = new System.Drawing.Point(30, 244);
            this.entityFromLbl.Name = "entityFromLbl";
            this.entityFromLbl.Size = new System.Drawing.Size(59, 13);
            this.entityFromLbl.TabIndex = 34;
            this.entityFromLbl.Text = "Entity From";
            // 
            // entityToLbl
            // 
            this.entityToLbl.AutoSize = true;
            this.entityToLbl.Location = new System.Drawing.Point(40, 218);
            this.entityToLbl.Name = "entityToLbl";
            this.entityToLbl.Size = new System.Drawing.Size(49, 13);
            this.entityToLbl.TabIndex = 35;
            this.entityToLbl.Text = "Entity To";
            // 
            // mainDatabaseDataSet1
            // 
            this.mainDatabaseDataSet1.DataSetName = "MainDatabaseDataSet1";
            this.mainDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTransactionBindingSource5
            // 
            this.tblTransactionBindingSource5.DataMember = "tblTransaction";
            this.tblTransactionBindingSource5.DataSource = this.mainDatabaseDataSet1;
            // 
            // tblTransactionTableAdapter1
            // 
            this.tblTransactionTableAdapter1.ClearBeforeFill = true;
            // 
            // tblTransactionBindingSource3
            // 
            this.tblTransactionBindingSource3.DataMember = "tblTransaction";
            this.tblTransactionBindingSource3.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTransactionBindingSource4
            // 
            this.tblTransactionBindingSource4.DataMember = "tblTransaction";
            this.tblTransactionBindingSource4.DataSource = this.mainDatabaseDataSet;
            // 
            // tblTransactionBindingSource2
            // 
            this.tblTransactionBindingSource2.DataMember = "tblTransaction";
            this.tblTransactionBindingSource2.DataSource = this.mainDatabaseDataSet;
            // 
            // tblTransactionBindingSource
            // 
            this.tblTransactionBindingSource.DataMember = "tblTransaction";
            this.tblTransactionBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // tblTransactionTableAdapter
            // 
            this.tblTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // tblTransactionBindingSource1
            // 
            this.tblTransactionBindingSource1.DataMember = "tblTransaction";
            this.tblTransactionBindingSource1.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet2
            // 
            this.mainDatabaseDataSet2.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.accountFromDataGridViewTextBoxColumn,
            this.accountToDataGridViewTextBoxColumn,
            this.bucketFromDataGridViewTextBoxColumn,
            this.bucketToDataGridViewTextBoxColumn,
            this.bankFromDataGridViewTextBoxColumn,
            this.bankToDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.entityFromDataGridViewTextBoxColumn,
            this.entityToDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTransactionBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(220, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // accountFromDataGridViewTextBoxColumn
            // 
            this.accountFromDataGridViewTextBoxColumn.DataPropertyName = "AccountFrom";
            this.accountFromDataGridViewTextBoxColumn.HeaderText = "AccountFrom";
            this.accountFromDataGridViewTextBoxColumn.Name = "accountFromDataGridViewTextBoxColumn";
            // 
            // accountToDataGridViewTextBoxColumn
            // 
            this.accountToDataGridViewTextBoxColumn.DataPropertyName = "AccountTo";
            this.accountToDataGridViewTextBoxColumn.HeaderText = "AccountTo";
            this.accountToDataGridViewTextBoxColumn.Name = "accountToDataGridViewTextBoxColumn";
            // 
            // bucketFromDataGridViewTextBoxColumn
            // 
            this.bucketFromDataGridViewTextBoxColumn.DataPropertyName = "BucketFrom";
            this.bucketFromDataGridViewTextBoxColumn.HeaderText = "BucketFrom";
            this.bucketFromDataGridViewTextBoxColumn.Name = "bucketFromDataGridViewTextBoxColumn";
            // 
            // bucketToDataGridViewTextBoxColumn
            // 
            this.bucketToDataGridViewTextBoxColumn.DataPropertyName = "BucketTo";
            this.bucketToDataGridViewTextBoxColumn.HeaderText = "BucketTo";
            this.bucketToDataGridViewTextBoxColumn.Name = "bucketToDataGridViewTextBoxColumn";
            // 
            // bankFromDataGridViewTextBoxColumn
            // 
            this.bankFromDataGridViewTextBoxColumn.DataPropertyName = "BankFrom";
            this.bankFromDataGridViewTextBoxColumn.HeaderText = "BankFrom";
            this.bankFromDataGridViewTextBoxColumn.Name = "bankFromDataGridViewTextBoxColumn";
            // 
            // bankToDataGridViewTextBoxColumn
            // 
            this.bankToDataGridViewTextBoxColumn.DataPropertyName = "BankTo";
            this.bankToDataGridViewTextBoxColumn.HeaderText = "BankTo";
            this.bankToDataGridViewTextBoxColumn.Name = "bankToDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // entityFromDataGridViewTextBoxColumn
            // 
            this.entityFromDataGridViewTextBoxColumn.DataPropertyName = "EntityFrom";
            this.entityFromDataGridViewTextBoxColumn.HeaderText = "EntityFrom";
            this.entityFromDataGridViewTextBoxColumn.Name = "entityFromDataGridViewTextBoxColumn";
            // 
            // entityToDataGridViewTextBoxColumn
            // 
            this.entityToDataGridViewTextBoxColumn.DataPropertyName = "EntityTo";
            this.entityToDataGridViewTextBoxColumn.HeaderText = "EntityTo";
            this.entityToDataGridViewTextBoxColumn.Name = "entityToDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.entityToLbl);
            this.Controls.Add(this.entityFromLbl);
            this.Controls.Add(this.entityToTxtBox);
            this.Controls.Add(this.entityFromTxtBox);
            this.Controls.Add(this.accountToComboBox);
            this.Controls.Add(this.bucketFromComboBox);
            this.Controls.Add(this.bucketToComboBox);
            this.Controls.Add(this.bankFromComboBox);
            this.Controls.Add(this.bankToComboBox);
            this.Controls.Add(this.accountFromComboBox);
            this.Controls.Add(this.bankFromlbl);
            this.Controls.Add(this.BankToLbl);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.accountToLbl);
            this.Controls.Add(this.bucketFromLbl);
            this.Controls.Add(this.bucketToLbl);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.accountFromLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addTransactionBtn);
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label accountFromLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label bucketToLbl;
        private System.Windows.Forms.Label bucketFromLbl;
        private System.Windows.Forms.Label accountToLbl;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.Label bankFromlbl;
        private System.Windows.Forms.Label BankToLbl;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource;
        private MainDatabaseDataSetTableAdapters.tblTransactionTableAdapter tblTransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketIdFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketIdToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource1;
        private System.Windows.Forms.ComboBox accountFromComboBox;
        private System.Windows.Forms.ComboBox bankToComboBox;
        private System.Windows.Forms.ComboBox bankFromComboBox;
        private System.Windows.Forms.ComboBox bucketToComboBox;
        private System.Windows.Forms.ComboBox bucketFromComboBox;
        private System.Windows.Forms.ComboBox accountToComboBox;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource2;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource3;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource4;
        private System.Windows.Forms.TextBox entityFromTxtBox;
        private System.Windows.Forms.TextBox entityToTxtBox;
        private System.Windows.Forms.Label entityFromLbl;
        private System.Windows.Forms.Label entityToLbl;
        private MainDatabaseDataSet1 mainDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource5;
        private MainDatabaseDataSet1TableAdapters.tblTransactionTableAdapter tblTransactionTableAdapter1;
        private MainDatabaseDataSet mainDatabaseDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}