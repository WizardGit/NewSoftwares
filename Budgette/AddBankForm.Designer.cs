namespace Budgette
{
    partial class AddBankForm
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
            this.tblBankDataGridView = new System.Windows.Forms.DataGridView();
            this.Bank = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bankTxtBox = new System.Windows.Forms.TextBox();
            this.createBankBtn = new System.Windows.Forms.Button();
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.tblBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBankTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblBankTableAdapter();
            this.bankIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBankDataGridView
            // 
            this.tblBankDataGridView.AutoGenerateColumns = false;
            this.tblBankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.tblBankDataGridView.DataSource = this.tblBankBindingSource;
            this.tblBankDataGridView.Location = new System.Drawing.Point(191, 14);
            this.tblBankDataGridView.Name = "tblBankDataGridView";
            this.tblBankDataGridView.Size = new System.Drawing.Size(383, 150);
            this.tblBankDataGridView.TabIndex = 22;
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Location = new System.Drawing.Point(17, 21);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(32, 13);
            this.Bank.TabIndex = 20;
            this.Bank.Text = "Bank";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(20, 124);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // bankTxtBox
            // 
            this.bankTxtBox.Location = new System.Drawing.Point(55, 18);
            this.bankTxtBox.Name = "bankTxtBox";
            this.bankTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bankTxtBox.TabIndex = 17;
            // 
            // createBankBtn
            // 
            this.createBankBtn.Location = new System.Drawing.Point(20, 73);
            this.createBankBtn.Name = "createBankBtn";
            this.createBankBtn.Size = new System.Drawing.Size(94, 23);
            this.createBankBtn.TabIndex = 16;
            this.createBankBtn.Text = "Create Bank";
            this.createBankBtn.UseVisualStyleBackColor = true;
            this.createBankBtn.Click += new System.EventHandler(this.createBankBtn_Click);
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBankBindingSource
            // 
            this.tblBankBindingSource.DataMember = "tblBank";
            this.tblBankBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // tblBankTableAdapter
            // 
            this.tblBankTableAdapter.ClearBeforeFill = true;
            // 
            // bankIdDataGridViewTextBoxColumn
            // 
            this.bankIdDataGridViewTextBoxColumn.DataPropertyName = "BankId";
            this.bankIdDataGridViewTextBoxColumn.HeaderText = "BankId";
            this.bankIdDataGridViewTextBoxColumn.Name = "bankIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // AddBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblBankDataGridView);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bankTxtBox);
            this.Controls.Add(this.createBankBtn);
            this.Name = "AddBankForm";
            this.Text = "AddBankForm";
            this.Load += new System.EventHandler(this.AddBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBankDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tblBankDataGridView;
        private System.Windows.Forms.Label Bank;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox bankTxtBox;
        private System.Windows.Forms.Button createBankBtn;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblBankBindingSource;
        private MainDatabaseDataSetTableAdapters.tblBankTableAdapter tblBankTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    }
}