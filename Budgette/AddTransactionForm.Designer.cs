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
            this.tblTransactionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tblTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblTransactionTableAdapter();
            this.tblTransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountFromComboBox = new System.Windows.Forms.ComboBox();
            this.bankToComboBox = new System.Windows.Forms.ComboBox();
            this.bankFromComboBox = new System.Windows.Forms.ComboBox();
            this.bucketToComboBox = new System.Windows.Forms.ComboBox();
            this.bucketFromComboBox = new System.Windows.Forms.ComboBox();
            this.accountToComboBox = new System.Windows.Forms.ComboBox();
            this.tblTransactionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblTransactionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTransactionBindingSource2
            // 
            this.tblTransactionBindingSource2.DataMember = "tblTransaction";
            this.tblTransactionBindingSource2.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(128, 215);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Location = new System.Drawing.Point(12, 215);
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
            this.label4.Location = new System.Drawing.Point(40, 192);
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
            this.amountTxtBox.Location = new System.Drawing.Point(103, 189);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.amountTxtBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bank From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Bank To";
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
            // tblTransactionBindingSource3
            // 
            this.tblTransactionBindingSource3.DataMember = "tblTransaction";
            this.tblTransactionBindingSource3.DataSource = this.mainDatabaseDataSet;
            // 
            // dataGridView1
            // 
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
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTransactionBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(222, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // tblTransactionBindingSource4
            // 
            this.tblTransactionBindingSource4.DataMember = "tblTransaction";
            this.tblTransactionBindingSource4.DataSource = this.mainDatabaseDataSet;
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
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.accountToComboBox);
            this.Controls.Add(this.bucketFromComboBox);
            this.Controls.Add(this.bucketToComboBox);
            this.Controls.Add(this.bankFromComboBox);
            this.Controls.Add(this.bankToComboBox);
            this.Controls.Add(this.accountFromComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addTransactionBtn);
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.BindingSource tblTransactionBindingSource4;
    }
}