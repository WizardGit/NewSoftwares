namespace Budgette
{
    partial class AddBucketForm
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
            this.tblBucketDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.balanceTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.createBucketBtn = new System.Windows.Forms.Button();
            this.mainDatabaseDataSet = new Budgette.MainDatabaseDataSet();
            this.tblBucketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBucketTableAdapter = new Budgette.MainDatabaseDataSetTableAdapters.tblBucketTableAdapter();
            this.bucketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblBucketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBucketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBucketDataGridView
            // 
            this.tblBucketDataGridView.AutoGenerateColumns = false;
            this.tblBucketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBucketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bucketIdDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.tblBucketDataGridView.DataSource = this.tblBucketBindingSource;
            this.tblBucketDataGridView.Location = new System.Drawing.Point(235, 4);
            this.tblBucketDataGridView.Name = "tblBucketDataGridView";
            this.tblBucketDataGridView.Size = new System.Drawing.Size(383, 150);
            this.tblBucketDataGridView.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bucket Name";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(134, 74);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // balanceTxtBox
            // 
            this.balanceTxtBox.Location = new System.Drawing.Point(109, 34);
            this.balanceTxtBox.Name = "balanceTxtBox";
            this.balanceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTxtBox.TabIndex = 9;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(109, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 8;
            // 
            // createBucketBtn
            // 
            this.createBucketBtn.Location = new System.Drawing.Point(15, 74);
            this.createBucketBtn.Name = "createBucketBtn";
            this.createBucketBtn.Size = new System.Drawing.Size(101, 23);
            this.createBucketBtn.TabIndex = 7;
            this.createBucketBtn.Text = "Create Bucket";
            this.createBucketBtn.UseVisualStyleBackColor = true;
            this.createBucketBtn.Click += new System.EventHandler(this.createBucketBtn_Click);
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBucketBindingSource
            // 
            this.tblBucketBindingSource.DataMember = "tblBucket";
            this.tblBucketBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // tblBucketTableAdapter
            // 
            this.tblBucketTableAdapter.ClearBeforeFill = true;
            // 
            // bucketIdDataGridViewTextBoxColumn
            // 
            this.bucketIdDataGridViewTextBoxColumn.DataPropertyName = "BucketId";
            this.bucketIdDataGridViewTextBoxColumn.HeaderText = "BucketId";
            this.bucketIdDataGridViewTextBoxColumn.Name = "bucketIdDataGridViewTextBoxColumn";
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // AddBucketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 188);
            this.Controls.Add(this.tblBucketDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.balanceTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.createBucketBtn);
            this.Name = "AddBucketForm";
            this.Text = "AddBucketForm";
            this.Load += new System.EventHandler(this.AddBucketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBucketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBucketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblBucketDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox balanceTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button createBucketBtn;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblBucketBindingSource;
        private MainDatabaseDataSetTableAdapters.tblBucketTableAdapter tblBucketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}