
namespace YahtzeeProbabilities
{
    partial class MainForm
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
            this.MainLabelOnes = new System.Windows.Forms.Label();
            this.OnesTextBox = new System.Windows.Forms.TextBox();
            this.OnesAnswer = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.calbut2 = new System.Windows.Forms.Button();
            this.templbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainLabelOnes
            // 
            this.MainLabelOnes.AutoSize = true;
            this.MainLabelOnes.Location = new System.Drawing.Point(101, 97);
            this.MainLabelOnes.Name = "MainLabelOnes";
            this.MainLabelOnes.Size = new System.Drawing.Size(84, 13);
            this.MainLabelOnes.TabIndex = 0;
            this.MainLabelOnes.Text = "Number of Ones";
            // 
            // OnesTextBox
            // 
            this.OnesTextBox.Location = new System.Drawing.Point(194, 94);
            this.OnesTextBox.Name = "OnesTextBox";
            this.OnesTextBox.Size = new System.Drawing.Size(100, 20);
            this.OnesTextBox.TabIndex = 1;
            // 
            // OnesAnswer
            // 
            this.OnesAnswer.AutoSize = true;
            this.OnesAnswer.Location = new System.Drawing.Point(322, 97);
            this.OnesAnswer.Name = "OnesAnswer";
            this.OnesAnswer.Size = new System.Drawing.Size(24, 13);
            this.OnesAnswer.TabIndex = 2;
            this.OnesAnswer.Text = "-1%";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(180, 146);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // calbut2
            // 
            this.calbut2.Location = new System.Drawing.Point(307, 219);
            this.calbut2.Name = "calbut2";
            this.calbut2.Size = new System.Drawing.Size(75, 23);
            this.calbut2.TabIndex = 6;
            this.calbut2.Text = "Calculate";
            this.calbut2.UseVisualStyleBackColor = true;
            this.calbut2.Click += new System.EventHandler(this.calbut2_Click);
            // 
            // templbl
            // 
            this.templbl.AutoSize = true;
            this.templbl.Location = new System.Drawing.Point(322, 255);
            this.templbl.Name = "templbl";
            this.templbl.Size = new System.Drawing.Size(24, 13);
            this.templbl.TabIndex = 7;
            this.templbl.Text = "-1%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "out of";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.templbl);
            this.Controls.Add(this.calbut2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OnesAnswer);
            this.Controls.Add(this.OnesTextBox);
            this.Controls.Add(this.MainLabelOnes);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabelOnes;
        private System.Windows.Forms.TextBox OnesTextBox;
        private System.Windows.Forms.Label OnesAnswer;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button calbut2;
        private System.Windows.Forms.Label templbl;
        private System.Windows.Forms.Label label2;
    }
}

