namespace Homework3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnFindNo = new System.Windows.Forms.Button();
            this.btnGetAVG = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnLessAvg = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnMoreAvg = new System.Windows.Forms.Button();
            this.btnGetMin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analysis of Random Numbers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 100);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(84, 251);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generated Numbers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutput.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(248, 100);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(344, 250);
            this.lblOutput.TabIndex = 4;
            // 
            // btnFindNo
            // 
            this.btnFindNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindNo.Location = new System.Drawing.Point(112, 100);
            this.btnFindNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindNo.Name = "btnFindNo";
            this.btnFindNo.Size = new System.Drawing.Size(117, 27);
            this.btnFindNo.TabIndex = 5;
            this.btnFindNo.Text = "Find a Number";
            this.btnFindNo.UseVisualStyleBackColor = true;
            this.btnFindNo.Click += new System.EventHandler(this.btnFindNo_Click);
            // 
            // btnGetAVG
            // 
            this.btnGetAVG.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAVG.Location = new System.Drawing.Point(112, 132);
            this.btnGetAVG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetAVG.Name = "btnGetAVG";
            this.btnGetAVG.Size = new System.Drawing.Size(117, 27);
            this.btnGetAVG.TabIndex = 6;
            this.btnGetAVG.Text = "Get Average";
            this.btnGetAVG.UseVisualStyleBackColor = true;
            this.btnGetAVG.Click += new System.EventHandler(this.btnGetAVG_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(112, 163);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(55, 27);
            this.btnMax.TabIndex = 7;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnLessAvg
            // 
            this.btnLessAvg.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessAvg.Location = new System.Drawing.Point(112, 195);
            this.btnLessAvg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLessAvg.Name = "btnLessAvg";
            this.btnLessAvg.Size = new System.Drawing.Size(117, 27);
            this.btnLessAvg.TabIndex = 9;
            this.btnLessAvg.Text = "Numbers < AVG";
            this.btnLessAvg.UseVisualStyleBackColor = true;
            this.btnLessAvg.Click += new System.EventHandler(this.btnLessAvg_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(112, 258);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 58);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate a New Set of Numbers\r\n";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnMoreAvg
            // 
            this.btnMoreAvg.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreAvg.Location = new System.Drawing.Point(112, 227);
            this.btnMoreAvg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoreAvg.Name = "btnMoreAvg";
            this.btnMoreAvg.Size = new System.Drawing.Size(117, 27);
            this.btnMoreAvg.TabIndex = 11;
            this.btnMoreAvg.Text = "Numbers > AVG";
            this.btnMoreAvg.UseVisualStyleBackColor = true;
            this.btnMoreAvg.Click += new System.EventHandler(this.btnMoreAvg_Click);
            // 
            // btnGetMin
            // 
            this.btnGetMin.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMin.Location = new System.Drawing.Point(172, 163);
            this.btnGetMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetMin.Name = "btnGetMin";
            this.btnGetMin.Size = new System.Drawing.Size(58, 27);
            this.btnGetMin.TabIndex = 12;
            this.btnGetMin.Text = "Min";
            this.btnGetMin.UseVisualStyleBackColor = true;
            this.btnGetMin.Click += new System.EventHandler(this.btnGetMin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(112, 322);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 27);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(172, 322);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Homework3.Properties.Resources.ut;
            this.pictureBox1.Location = new System.Drawing.Point(490, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetMin);
            this.Controls.Add(this.btnMoreAvg);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLessAvg);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnGetAVG);
            this.Controls.Add(this.btnFindNo);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnFindNo;
        private System.Windows.Forms.Button btnGetAVG;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnLessAvg;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnMoreAvg;
        private System.Windows.Forms.Button btnGetMin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

