namespace AppTracNghiem
{
    partial class frmX
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
            this.txtCH = new System.Windows.Forms.RichTextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.chA = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.chB = new System.Windows.Forms.RadioButton();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.chC = new System.Windows.Forms.RadioButton();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.chD = new System.Windows.Forms.RadioButton();
            this.txtD = new System.Windows.Forms.RichTextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGo = new System.Windows.Forms.TextBox();
            this.txtCauHoiSo = new System.Windows.Forms.Label();
            this.txtYES = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSAI = new System.Windows.Forms.Button();
            this.txtNameCH = new System.Windows.Forms.Label();
            this.txtTick = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtDiem = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.Label();
            this.txtAN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoCau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCH
            // 
            this.txtCH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCH.ForeColor = System.Drawing.Color.Blue;
            this.txtCH.Location = new System.Drawing.Point(201, 99);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(1427, 146);
            this.txtCH.TabIndex = 0;
            this.txtCH.Text = "";
            this.txtCH.TextChanged += new System.EventHandler(this.txtCH_TextChanged);
            this.txtCH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCH_KeyDown);
            this.txtCH.ImeModeChanged += new System.EventHandler(this.txtCH_ImeModeChanged);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(531, 36);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(437, 22);
            this.txtFile.TabIndex = 1;
            this.txtFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFile_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn file";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(746, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Bắt đầu";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
            this.btnOK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOK_KeyPress);
            // 
            // chA
            // 
            this.chA.AutoSize = true;
            this.chA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chA.Location = new System.Drawing.Point(26, 327);
            this.chA.Name = "chA";
            this.chA.Size = new System.Drawing.Size(107, 24);
            this.chA.TabIndex = 6;
            this.chA.TabStop = true;
            this.chA.Text = "Đáp án A";
            this.chA.UseVisualStyleBackColor = true;
            this.chA.CheckedChanged += new System.EventHandler(this.chA_CheckedChanged);
            this.chA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chA_KeyDown);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.Khaki;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(201, 293);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(1427, 98);
            this.txtA.TabIndex = 5;
            this.txtA.Text = "";
            this.txtA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtA_KeyDown);
            // 
            // chB
            // 
            this.chB.AutoSize = true;
            this.chB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chB.Location = new System.Drawing.Point(24, 427);
            this.chB.Name = "chB";
            this.chB.Size = new System.Drawing.Size(108, 24);
            this.chB.TabIndex = 8;
            this.chB.TabStop = true;
            this.chB.Text = "Đáp án B";
            this.chB.UseVisualStyleBackColor = true;
            this.chB.CheckedChanged += new System.EventHandler(this.chB_CheckedChanged);
            this.chB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chB_KeyDown);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.Khaki;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(201, 397);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(1427, 98);
            this.txtB.TabIndex = 7;
            this.txtB.Text = "";
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // chC
            // 
            this.chC.AutoSize = true;
            this.chC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chC.Location = new System.Drawing.Point(25, 533);
            this.chC.Name = "chC";
            this.chC.Size = new System.Drawing.Size(108, 24);
            this.chC.TabIndex = 10;
            this.chC.TabStop = true;
            this.chC.Text = "Đáp án C";
            this.chC.UseVisualStyleBackColor = true;
            this.chC.CheckedChanged += new System.EventHandler(this.chC_CheckedChanged);
            this.chC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chC_KeyDown);
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.Khaki;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(201, 501);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(1427, 98);
            this.txtC.TabIndex = 9;
            this.txtC.Text = "";
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            this.txtC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtC_KeyDown);
            // 
            // chD
            // 
            this.chD.AutoSize = true;
            this.chD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chD.Location = new System.Drawing.Point(26, 644);
            this.chD.Name = "chD";
            this.chD.Size = new System.Drawing.Size(109, 24);
            this.chD.TabIndex = 12;
            this.chD.TabStop = true;
            this.chD.Text = "Đáp án D";
            this.chD.UseVisualStyleBackColor = true;
            this.chD.CheckedChanged += new System.EventHandler(this.chD_CheckedChanged);
            this.chD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chD_KeyDown);
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.Khaki;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtD.Location = new System.Drawing.Point(201, 605);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(1427, 98);
            this.txtD.TabIndex = 11;
            this.txtD.Text = "";
            this.txtD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtD_KeyDown);
            this.txtD.ImeModeChanged += new System.EventHandler(this.txtD_ImeModeChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnd.Location = new System.Drawing.Point(766, 723);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(129, 47);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "Kết Thúc";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            this.btnEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEnd_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(511, 727);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 69);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBack_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(1010, 727);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 69);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNext_KeyDown);
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(271, 65);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(129, 28);
            this.btnGO.TabIndex = 18;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            this.btnGO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGO_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "ĐI đến câu số";
            // 
            // txtGo
            // 
            this.txtGo.Location = new System.Drawing.Point(127, 68);
            this.txtGo.Name = "txtGo";
            this.txtGo.Size = new System.Drawing.Size(138, 22);
            this.txtGo.TabIndex = 16;
            this.txtGo.TextChanged += new System.EventHandler(this.txtGo_TextChanged);
            this.txtGo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGo_KeyDown);
            this.txtGo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGo_KeyPress);
            this.txtGo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGo_KeyUp);
            // 
            // txtCauHoiSo
            // 
            this.txtCauHoiSo.AutoSize = true;
            this.txtCauHoiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoiSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCauHoiSo.Location = new System.Drawing.Point(20, 168);
            this.txtCauHoiSo.Name = "txtCauHoiSo";
            this.txtCauHoiSo.Size = new System.Drawing.Size(114, 25);
            this.txtCauHoiSo.TabIndex = 19;
            this.txtCauHoiSo.Text = "CÂU SỐ 1";
            this.txtCauHoiSo.Click += new System.EventHandler(this.txtCauHoiSo_Click);
            // 
            // txtYES
            // 
            this.txtYES.AutoSize = true;
            this.txtYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYES.Location = new System.Drawing.Point(39, 207);
            this.txtYES.Name = "txtYES";
            this.txtYES.Size = new System.Drawing.Size(0, 20);
            this.txtYES.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Thời gian làm bài";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(547, 67);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(138, 22);
            this.txtTime.TabIndex = 21;
            this.txtTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTime_KeyDown);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            this.txtTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTime_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "phút";
            // 
            // btnSAI
            // 
            this.btnSAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSAI.Location = new System.Drawing.Point(720, 770);
            this.btnSAI.Name = "btnSAI";
            this.btnSAI.Size = new System.Drawing.Size(221, 38);
            this.btnSAI.TabIndex = 24;
            this.btnSAI.Text = "Xem chi tiết";
            this.btnSAI.UseVisualStyleBackColor = true;
            this.btnSAI.Click += new System.EventHandler(this.btnSAI_Click);
            this.btnSAI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSAI_KeyDown);
            this.btnSAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSAI_KeyPress);
            // 
            // txtNameCH
            // 
            this.txtNameCH.AutoSize = true;
            this.txtNameCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCH.ForeColor = System.Drawing.Color.Indigo;
            this.txtNameCH.Location = new System.Drawing.Point(1005, 9);
            this.txtNameCH.Name = "txtNameCH";
            this.txtNameCH.Size = new System.Drawing.Size(0, 25);
            this.txtNameCH.TabIndex = 25;
            // 
            // txtTick
            // 
            this.txtTick.AutoSize = true;
            this.txtTick.BackColor = System.Drawing.Color.Yellow;
            this.txtTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTick.Location = new System.Drawing.Point(3, 5);
            this.txtTick.Name = "txtTick";
            this.txtTick.Size = new System.Drawing.Size(139, 29);
            this.txtTick.TabIndex = 26;
            this.txtTick.Text = "00 : 00 : 00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDiem
            // 
            this.txtDiem.AutoSize = true;
            this.txtDiem.BackColor = System.Drawing.Color.Aquamarine;
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDiem.Location = new System.Drawing.Point(1028, 49);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(206, 20);
            this.txtDiem.TabIndex = 27;
            this.txtDiem.Text = "ĐIỂM CỦA BẠN : 10/10";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.Location = new System.Drawing.Point(402, -1);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(123, 32);
            this.btnChooseFile.TabIndex = 28;
            this.btnChooseFile.Text = "Chọn File";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            this.btnChooseFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnChooseFile_KeyDown);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(171, 1);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 46);
            this.btnAgain.TabIndex = 29;
            this.btnAgain.Text = "LÀM LẠI MỚI";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            this.btnAgain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAgain_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(252, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 46);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "LÀM KHÁC MỚI";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtKey
            // 
            this.txtKey.AutoSize = true;
            this.txtKey.BackColor = System.Drawing.Color.Goldenrod;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtKey.Location = new System.Drawing.Point(1634, 99);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(47, 15);
            this.txtKey.TabIndex = 31;
            this.txtKey.Text = "label5";
            // 
            // txtAN
            // 
            this.txtAN.AutoSize = true;
            this.txtAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAN.ForeColor = System.Drawing.Color.Red;
            this.txtAN.Location = new System.Drawing.Point(1632, 65);
            this.txtAN.Name = "txtAN";
            this.txtAN.Size = new System.Drawing.Size(41, 25);
            this.txtAN.TabIndex = 32;
            this.txtAN.Text = "[X]";
            this.txtAN.Click += new System.EventHandler(this.txtAN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(531, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giới hạn số câu cần làm (nếu để trống thì làm hết số câu hiện có)";
            // 
            // txtSoCau
            // 
            this.txtSoCau.Location = new System.Drawing.Point(871, 27);
            this.txtSoCau.Name = "txtSoCau";
            this.txtSoCau.Size = new System.Drawing.Size(76, 22);
            this.txtSoCau.TabIndex = 33;
            // 
            // frmX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1924, 832);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoCau);
            this.Controls.Add(this.txtAN);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtTick);
            this.Controls.Add(this.txtNameCH);
            this.Controls.Add(this.btnSAI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtYES);
            this.Controls.Add(this.txtCauHoiSo);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.chD);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.chC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.chB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.chA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtCH);
            this.Name = "frmX";
            this.Text = "APP TRAC NGHIEM - PRACTICE DEMO (có giới hạn số câu)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmX_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCH;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton chA;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RadioButton chB;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RadioButton chC;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RadioButton chD;
        private System.Windows.Forms.RichTextBox txtD;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGo;
        private System.Windows.Forms.Label txtCauHoiSo;
        private System.Windows.Forms.Label txtYES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSAI;
        private System.Windows.Forms.Label txtNameCH;
        private System.Windows.Forms.Label txtTick;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txtDiem;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label txtKey;
        private System.Windows.Forms.Label txtAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoCau;
    }
}

