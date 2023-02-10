using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConvertTest_TracNghiemFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xoá hết Enter... #3275#

            String s = "\n" + txtInput.Text;

            //s += "\n" + s;

            s = s.Replace("\n", "#3275#");

            //cập nhật theo nhu cầu (trước tiên)...

           
                s = s.Replace(txtA.Text, "\n");
                s = s.Replace(txtB.Text, "\n");
                s = s.Replace(txtC.Text, "\n");
                s = s.Replace(txtD.Text, "\n");


            //......................................................................


          // s = s.Replace("#3275#", " ");

            // cập nhật txtDapAn...

            string d = txtDapAn.Text;

            d = d.Replace("A", "1");
            d = d.Replace("B", "2");
            d = d.Replace("C", "3");
            d = d.Replace("D", "4");

            char[] dd = { '\n' };
            d = d.TrimStart(dd);
            d = d.TrimEnd(dd);

            string[] dapan = d.Split('\n');

            string[] CH_STT = txtNum.Text.Split('.');

            // Cập nhật STT câu hỏi ...

           for (int i = 0; i<CH_STT.Length;i++)
            {
                string[] STT_CH = CH_STT[i].Split('-');
                for (int j = int.Parse(STT_CH[0]);j <= int.Parse(STT_CH[1]); j++)
                s = s.Replace(txtX.Text+(j).ToString()+txtXX.Text, "\n");
            }

            s = s.Replace("#3275#", " ");

            // xoá các Enter thừa của dữ liệu

            do
            {
                s = s.Replace("\n\n", "\n");
            }
            while (s.IndexOf("\n\n") != -1);

            char[] ss = { '\n' };
            s = s.TrimStart(ss);
            s = s.TrimEnd(ss);

            // Kiểm tra nếu dữ liệu không đủ hợp với đáp án :

            string[] dulieu = s.Split('\n');

            txtInput.Text = s;

            if (dulieu.Length / 5 != dapan.Length)
            {
                MessageBox.Show("Số lượng câu hỏi của bạn trong dữ liệu không khớp với đáp án của bạn (lỗi do thiếu hoặc dư)...\n\n+ Số lượng dữ liệu : "+dulieu.Length/5+"\n Số lượng đáp án : "+dapan.Length);
                //this.Close();
                return;
            }

            
            // Phân tích những câu không cần hoán vị...

            string[] notSwap = txtNoSwap.Text.Split('.');
                int[] hv = new int[dapan.Length];
                for (int i = 0; i < dapan.Length; i++)
                    hv[i] = 0;

            if (txtNoSwap.Text.IndexOf(".") != -1)
            {
                for (int i = 0; i < notSwap.Length; i++)
                {
                    hv[int.Parse(notSwap[i]) - 1] = 1;
                }
            }
           
            // Hoàn chỉnh và copy nội dung sau khi phân tích...

            string copy = "";
            int k = 0;
            for (int i = 0; i<dulieu.Length;i=i+5)
            {
                string CH;
                if (hv[i/5] == 1)
                    CH = "$" + dulieu[i];
                else
                    CH = dulieu[i];

                string DA = "";
                if (int.Parse(dapan[k]) == 1)
                    DA = "[" + dulieu[i + 1] + "]";
                else
                    if (int.Parse(dapan[k]) == 2)
                    DA = "[" + dulieu[i + 2] + "]";
                else
                    if (int.Parse(dapan[k]) == 3)
                    DA = "[" + dulieu[i + 3] + "]";
                else
                    if (int.Parse(dapan[k]) == 4)
                    DA = "[" + dulieu[i + 4] + "]";

                    copy += CH + "\n" + dulieu[i + 1] + "\n" + dulieu[i + 2] + "\n" + dulieu[i + 3] + "\n" + dulieu[i + 4] + "\n" + DA + "\n#\n";
                k++;
            }

            char[] cc = { '\n', '#' ,'\n' };
            copy = copy.TrimEnd(cc);

            File.WriteAllText(txtFile.Text, copy);
            MessageBox.Show("Convert thành công...Một nội dung mới đã được cập nhật vào File chỉ định của bạn, tuy nhiên bạn cũng nên kiểm tra lại [80%]...");
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFile.Focus();
            txtDapAn.ReadOnly = true;
        }

        private void txtFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = file.FileName;
                    txtInput.Text = File.ReadAllText(txtFile.Text);
                    txtX.Text = "";
                    txtXX.Text = "";
                    txtA.Text = "";
                }
            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Replace(txtX.Text,"");
            MessageBox.Show("OK SUCCESS...PLEASE CONTINUE!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        int demDA = 0;
        private void txtDapAn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                demDA++;
                lbDem.Text = demDA.ToString();
                txtDapAn.Text += "A\n";
            }

            if (e.KeyCode == Keys.B)
            {
                demDA++;
                lbDem.Text = demDA.ToString();
                txtDapAn.Text += "B\n";
            }

            if (e.KeyCode == Keys.C)
            {
                demDA++;
                lbDem.Text = demDA.ToString();
                txtDapAn.Text += "C\n";
            }

            if (e.KeyCode == Keys.D)
            {
                demDA++;
                lbDem.Text = demDA.ToString();
                txtDapAn.Text += "D\n";
            }
        }

        private void txtDapAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
  
        }
    }
}
