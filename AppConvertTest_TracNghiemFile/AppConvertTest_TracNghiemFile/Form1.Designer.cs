namespace AppConvertTest_TracNghiemFile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoSwap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDapAn = new System.Windows.Forms.RichTextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtXX = new System.Windows.Forms.RichTextBox();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.txtD = new System.Windows.Forms.RichTextBox();
            this.txtX = new System.Windows.Forms.RichTextBox();
            this.lbDem = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dán dữ liệu gốc vào đây (bạn tự hiểu :)) - nên kiểm tra lại)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(666, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "X - Đáp án A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(666, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "X - Đáp án D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(666, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "X - Đáp án B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(666, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "X - Đáp án C";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 71);
            this.button1.TabIndex = 11;
            this.button1.Text = "CONVERT AND COPY CHANGE THIS FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(633, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Những câu không cần hoán vị đáp án (cách nhau bởi dấu chấm - theo index hệ thống)" +
    "\r\nVD : 1.5.10.28.62";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNoSwap
            // 
            this.txtNoSwap.Location = new System.Drawing.Point(194, 165);
            this.txtNoSwap.Name = "txtNoSwap";
            this.txtNoSwap.Size = new System.Drawing.Size(376, 22);
            this.txtNoSwap.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 160);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dãy đáp án theo từng câu - Ví dụ :\r\nC\r\nD\r\nA\r\nA\r\nB\r\nC\r\n...";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(98, 214);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.ReadOnly = true;
            this.txtDapAn.Size = new System.Drawing.Size(189, 268);
            this.txtDapAn.TabIndex = 15;
            this.txtDapAn.Text = "";
            this.txtDapAn.TextChanged += new System.EventHandler(this.txtDapAn_TextChanged);
            this.txtDapAn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDapAn_KeyDown);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(16, 32);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(495, 22);
            this.txtFile.TabIndex = 16;
            this.txtFile.Text = "Nhấn Enter để chọn file TXT dữ liệu";
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            this.txtFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFile_KeyDown);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.Aquamarine;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Location = new System.Drawing.Point(313, 214);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(611, 268);
            this.txtInput.TabIndex = 25;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(802, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "***";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1440, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(293, 60);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(218, 22);
            this.txtNum.TabIndex = 31;
            this.txtNum.Text = "0-0.0-0.0-0";
            // 
            // txtXX
            // 
            this.txtXX.Location = new System.Drawing.Point(831, 2);
            this.txtXX.Name = "txtXX";
            this.txtXX.Size = new System.Drawing.Size(123, 21);
            this.txtXX.TabIndex = 33;
            this.txtXX.Text = "CH - Behind _ Not Number";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(801, 33);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(126, 24);
            this.txtA.TabIndex = 34;
            this.txtA.Text = "";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(801, 69);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(126, 24);
            this.txtB.TabIndex = 35;
            this.txtB.Text = "";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(802, 107);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(126, 24);
            this.txtC.TabIndex = 36;
            this.txtC.Text = "";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(802, 153);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(126, 24);
            this.txtD.TabIndex = 37;
            this.txtD.Text = "";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(670, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(126, 24);
            this.txtX.TabIndex = 32;
            this.txtX.Text = "CH - In front of _ Not Number";
            // 
            // lbDem
            // 
            this.lbDem.AutoSize = true;
            this.lbDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbDem.Location = new System.Drawing.Point(28, 364);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(23, 25);
            this.lbDem.TabIndex = 39;
            this.lbDem.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(554, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "#3275# = Enter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 494);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDem);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtXX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtDapAn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoSwap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppConvertTest_TracNghiemFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoSwap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDapAn;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.RichTextBox txtXX;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtD;
        private System.Windows.Forms.RichTextBox txtX;
        private System.Windows.Forms.Label lbDem;
        private System.Windows.Forms.Label label9;
    }
}

