﻿namespace Budgette
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
            this.tblBucketDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.balanceTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.createBucketBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblBucketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBucketDataGridView
            // 
            this.tblBucketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblBucketDataGridView)).EndInit();
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
    }
}