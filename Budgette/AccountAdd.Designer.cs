
namespace Budgette
{
    partial class AccountAdd
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
            this.AccountCreateBtn = new System.Windows.Forms.Button();
            this.AccountTxt = new System.Windows.Forms.TextBox();
            this.AccountAddLbl = new System.Windows.Forms.Label();
            this.CancelAccountBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Budgette.Database1DataSet();
            this.tblAcctBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcctTableAdapter = new Budgette.Database1DataSetTableAdapters.tblAcctTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcctBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountCreateBtn
            // 
            this.AccountCreateBtn.Location = new System.Drawing.Point(12, 61);
            this.AccountCreateBtn.Name = "AccountCreateBtn";
            this.AccountCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.AccountCreateBtn.TabIndex = 0;
            this.AccountCreateBtn.Text = "Create/Add";
            this.AccountCreateBtn.UseVisualStyleBackColor = true;
            this.AccountCreateBtn.Click += new System.EventHandler(this.AccountCreateBtn_Click);
            // 
            // AccountTxt
            // 
            this.AccountTxt.Location = new System.Drawing.Point(15, 35);
            this.AccountTxt.Name = "AccountTxt";
            this.AccountTxt.Size = new System.Drawing.Size(153, 20);
            this.AccountTxt.TabIndex = 1;
            // 
            // AccountAddLbl
            // 
            this.AccountAddLbl.AutoSize = true;
            this.AccountAddLbl.Location = new System.Drawing.Point(12, 9);
            this.AccountAddLbl.Name = "AccountAddLbl";
            this.AccountAddLbl.Size = new System.Drawing.Size(128, 13);
            this.AccountAddLbl.TabIndex = 2;
            this.AccountAddLbl.Text = "Name of Account To Add";
            // 
            // CancelAccountBtn
            // 
            this.CancelAccountBtn.Location = new System.Drawing.Point(93, 61);
            this.CancelAccountBtn.Name = "CancelAccountBtn";
            this.CancelAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelAccountBtn.TabIndex = 3;
            this.CancelAccountBtn.Text = "Cancel";
            this.CancelAccountBtn.UseVisualStyleBackColor = true;
            this.CancelAccountBtn.Click += new System.EventHandler(this.CancelAccountBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAcctBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(229, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAcctBindingSource
            // 
            this.tblAcctBindingSource.DataMember = "tblAcct";
            this.tblAcctBindingSource.DataSource = this.database1DataSet;
            // 
            // tblAcctTableAdapter
            // 
            this.tblAcctTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // AccountAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CancelAccountBtn);
            this.Controls.Add(this.AccountAddLbl);
            this.Controls.Add(this.AccountTxt);
            this.Controls.Add(this.AccountCreateBtn);
            this.Name = "AccountAdd";
            this.Text = "AccountAdd";
            this.Load += new System.EventHandler(this.AccountAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcctBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccountCreateBtn;
        private System.Windows.Forms.TextBox AccountTxt;
        private System.Windows.Forms.Label AccountAddLbl;
        private System.Windows.Forms.Button CancelAccountBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblAcctBindingSource;
        private Database1DataSetTableAdapters.tblAcctTableAdapter tblAcctTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
    }
}