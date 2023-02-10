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

namespace AppTracNghiem
{
    public partial class frmX : Form
    {
        String[] ch;
        String[] a;
        String[] b;
        String[] c;
        String[] d;
        String[] dung;
        String[] choose;
        int position = 0;
        int n = 0;
        int xong = 0;
        String ND_file = "";

        int[] chuaxet_ch;
        int[][] chuaxet_da;

        int timeX = 0;

        public frmX()
        {
            InitializeComponent();

            txtKey.Text = "\n* CÁC PHÍM TẮT MÀ BẠN CÓ THỂ SỬ DỤNG ... :\n\n+ ENTER, xử lý thích hợp một trong các trường hợp sau :\n\n- Chọn file văn bản trắc nghiệm\n- Nhập thời gian làm bài\n- Bắt đầu sẵn sàng với bài kiểm tra trắc nghiệm\n- Đi đến vị trí câu hỏi mà bạn muốn\n- Đi đến câu hỏi tiếp theo\n\n+ A : chọn đáp án A cho câu hỏi hiện tại\n\n+ B : chọn đáp án B cho câu hỏi hiện tại\n\n+ C : chọn đáp án C cho câu hỏi hiện tại\n\n+ D : chọn đáp án D cho câu hỏi hiện tại\n\n+ X : Làm lại bài kiểm tra tương đương hiện tại\n\n+ P : Thực hiện bài kiểm tra mới khác\n\n+ L : nhập vị trí câu hỏi bạn muốn đến\n\n+ S : xem chi tiết bài kiểm tra hiện tại của bạn\n\n+ [Space] : trở về câu hỏi trước đó\n\n";
            txtAN.Text = "[?]";
            txtAN.ForeColor = Color.Green;
            txtKey.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //txtA.Enabled = false;
            //txtB.Enabled = false;
            //txtC.Enabled = false;
            //txtD.Enabled = false;
            //txtCH.Enabled = false;

            chA.Enabled = false;
            chB.Enabled = false;
            chC.Enabled = false;
            chD.Enabled = false;

            btnAgain.Visible = false;
            btnNew.Visible = false;

            btnSAI.Visible = false;
            txtDiem.Visible = false;

            txtFile.Focus();

            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            txtC.ReadOnly = true;
            txtD.ReadOnly = true;
            txtCH.ReadOnly = true;

            btnBack.Enabled = false;
            btnEnd.Enabled = false;
            btnGO.Enabled = false;
            btnNext.Enabled = false;
            txtGo.Text = "1";
            chA.Checked = true;
        }

        private String docfile (String filename)
        {
            string[] a = File.ReadAllLines(filename);
            String s = "";
            for (int i = 0; i < a.Length; ++i)
            {
                s = s + a[i];
                if (i < a.Length - 1)
                    s = s + "\n";
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (File.Exists(txtFile.Text) == false)
            {
                MessageBox.Show("Đường dẫn file không đúng, hãy đảm báo bạn đã copy đủ chính xác đường dẫn trong trường nhập.");
                txtFile.Focus();
                txtFile.Text = "";
                return;
            }

            String file = docfile(txtFile.Text);
            ND_file = file;

            if (ND_file.Length == 0)
            {
                MessageBox.Show("Bài kiểm tra hay file văn bản của bạn hiện chưa có câu hỏi nào!");
                return;
            }

            String[] split = { "\n#\n" };
            String[] t1 = file.Split(split,StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < t1.Length; i++)
            {
                String[] t2 = t1[i].Split('\n');
                if (t2.Length != 6)
                {
                    MessageBox.Show("WRONG QUESTION TO\n[" + t2[0] + "]\n");
                    MessageBox.Show("Định dạng file bạn đã chọn không đúng cú pháp (vui lòng kiểm tra và thử chọn lại file văn bản hoặc liên hệ Admin)! \n\n[CHÚ Ý : Kí tự # dùng để báo hiệu khoảng cách biệt mỗi câu, vì vậy tránh sử dụng # xuất hiện trong mỗi phần câu hỏi, còn $ dùng đế xác định câu hỏi không cần hoán vị đáp án. Xin lỗi vì sự bất tiện này! ]");
                    txtFile.Focus();
                    txtFile.Text = "";
                    return;
                }

                char[] t2_x = t2[5].ToCharArray();
                if (t2_x[0] != '[' || t2_x[t2[5].Length-1] != ']')
                {
                    MessageBox.Show("WRONG QUESTION TO\n[" + t2[0] + "]\n");
                    MessageBox.Show("Định dạng file bạn đã chọn không đúng cú pháp (vui lòng kiểm tra và thử chọn lại file văn bản hoặc liên hệ Admin)! \n\n[CHÚ Ý : Kí tự # dùng để báo hiệu khoảng cách biệt mỗi câu, vì vậy tránh sử dụng # xuất hiện trong mỗi phần câu hỏi, còn $ dùng đế xác định câu hỏi không cần hoán vị đáp án. Xin lỗi vì sự bất tiện này! ]");
                    txtFile.Focus();
                    txtFile.Text = "";
                    return;
                }
            }


            for (int i = 0; i < t1.Length; i++)
            {
                String[] t2 = t1[i].Split('\n');
                int flag = 0;
                String DA = t2[t2.Length - 1].Replace("[", "");
                DA = DA.Replace("]", "");
                for (int j = t2.Length - 2; j > 0; j--)
                {
                    if (DA.CompareTo(t2[j]) == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    //MessageBox.Show("Định dạng file bạn đã chọn không đúng cú pháp (vui lòng kiểm tra và thử chọn lại file văn bản hoặc liên hệ Admin)! \n\n[CHÚ Ý : Kí tự # dùng để báo hiệu khoảng cách biệt mỗi câu, vì vậy tránh sử dụng # xuất hiện trong mỗi phần câu hỏi.\nXin lỗi vì sự bất tiện này! ]");
                    MessageBox.Show("WRONG ANSWER TO\n[" + t2[0] + "]\n");
                    txtFile.Focus();
                    txtFile.Text = "";
                    txtFile.Text = t2[0];
                    return;
                }
            }

            if (txtTime.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thời gian làm bài...");
                txtTime.Focus();
                txtTime.Text = "";
                return;
            }

           for (int i=0;i<txtTime.Text.Length;i++)
            {
                if(txtTime.Text[i] < '0' || txtTime.Text[i] > '9')
                {
                    MessageBox.Show("Thời gian làm bài phải là một số !");
                    txtTime.Focus();
                    txtTime.Text = "";
                    return;
                }
            }

            int time = int.Parse(txtTime.Text);
            if (time < 1 || time > 1200)
            {
                MessageBox.Show("Thời gian làm bài phải tối thiểu 1 phút và không vượt quá 20 giờ...");
                txtTime.Focus();
                txtTime.Text = "";
                return;
            }

            n = t1.Length;

            if (txtSoCau.Text.Length >0 && int.Parse(txtSoCau.Text) > n)
            {
                MessageBox.Show("Giới hạn số câu bạn cần làm vượt quá số lượng tất cả mà đang hiện có...");
                return;
            }

            if (txtSoCau.Text.Length ==0)
                txtNameCH.Text = "Tổng số câu hiện có là " + n;
            else
                txtNameCH.Text = "Tổng số câu hiện có là " + n+" (chỉ làm "+txtSoCau.Text+" câu)";

            timeX = time * 60;

            

            chA.Enabled = true;
            chB.Enabled = true;
            chC.Enabled = true;
            chD.Enabled = true;

            btnBack.Enabled = true;

            btnChooseFile.Enabled = false;

            txtCH.Focus();

           

            btnOK.Enabled = false;
            btnEnd.Enabled = true;
            btnGO.Enabled = true;
            if (t1.Length > 1)
            btnNext.Enabled = true;

            txtTime.ReadOnly = true;
            txtFile.ReadOnly = true;
            txtSoCau.ReadOnly = true;

            ch = new String[t1.Length];
            a = new String[t1.Length];
            b = new String[t1.Length];
            c = new String[t1.Length];
            d = new String[t1.Length];
            dung = new String[t1.Length];
            choose = new String[t1.Length];

            chuaxet_ch = new int[t1.Length];

            chuaxet_da = new int[t1.Length][];
            for (int i = 0; i < t1.Length; i++)
                chuaxet_da[i] = new int[5];

            //for (int i = 0; i < t1.Length; i++)
            //{
            //    String[] t2 = t1[i].Split('\n');
            //    ch[i] = t2[0];
            //    a[i] = t2[1];
            //    b[i] = t2[2];
            //    c[i] = t2[3];
            //    d[i] = t2[4];
            //    dung[i] = t2[5];
            //}

            

            int dem = 0;
            while (true)
            {
                if (dem == t1.Length)
                    break;


                Random r = new Random();
                double x = r.Next(0, t1.Length);

                if (chuaxet_ch[int.Parse(x.ToString())] == 1)
                    continue;

                chuaxet_ch[int.Parse(x.ToString())] = 1;
                int i = int.Parse(x.ToString());
                String[] t2 = t1[i].Split('\n');

                char[] CH = t2[0].ToCharArray();

                if (CH[0] == '$')
                {
                    t2[0].Remove(0,1);
                    ch[dem] = t2[0].Replace("$","");
                    a[dem] = t2[1];
                    b[dem] = t2[2];
                    c[dem] = t2[3];
                    d[dem] = t2[4];
                    String DAx = t2[5].Replace("[", "");
                    DAx = DAx.Replace("]", "");
                    dung[dem] = DAx;
                }
                else
                {
                    int aa, bb, cc, dd;

                    ch[dem] = t2[0];

                    do
                    {
                        aa = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(aa.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(aa.ToString())] = 1;


                    a[dem] = t2[aa];

                    do
                    {
                        bb = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(bb.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(bb.ToString())] = 1;


                    b[dem] = t2[bb];

                    do
                    {
                        cc = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(cc.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(cc.ToString())] = 1;

                    c[dem] = t2[cc];

                    do
                    {
                        dd = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(dd.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(dd.ToString())] = 1;

                    d[dem] = t2[dd];
                    String DA = t2[5].Replace("[", "");
                    DA = DA.Replace("]", "");
                    dung[dem] = DA;
                }
                dem++;
            }

            for (int i=0;i<n;i++)
            {
                choose[i] = a[i];
            }
            txtGo.Text = "1";
            chA.Checked = true;
            MessageBox.Show("Bắt đầu - đã sẵn sàng làm bài kiểm tra trắc nghiệm ! ");
            txtCH.Text = ch[position];
            txtA.Text = a[position];
            txtB.Text = b[position];
            txtC.Text = c[position];
            txtD.Text = d[position];
            timer1_Tick(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (position == 0)
            //    return;

            //if (position == 1)
            //    btnBack.Enabled = false;

            btnNext.Enabled = true;

            txtCH.Focus();

            if (chA.Checked == true)
                choose[position] = txtA.Text;
            if (chB.Checked == true)
                choose[position] = txtB.Text;
            if (chC.Checked == true)
                choose[position] = txtC.Text;
            if (chD.Checked == true)
                choose[position] = txtD.Text;

            if (position == 0)
            {
                if (txtSoCau.Text.Length == 0)
                    position = n;
                else
                    position = int.Parse(txtSoCau.Text);
            }

            position--;
            txtGo.Text = (position + 1).ToString();
            int x = position + 1;
            txtCauHoiSo.Text = "CÂU SỐ " + x;
            txtCH.Text = ch[position];
            txtA.Text = a[position];
            txtB.Text = b[position];
            txtC.Text = c[position];
            txtD.Text = d[position];

            if (txtA.Text.CompareTo(choose[position])==0)
            {
                chA.Checked = true;
            }
            if (txtB.Text.CompareTo(choose[position]) == 0)
            {
                chB.Checked = true;
            }
            if (txtC.Text.CompareTo(choose[position]) == 0)
            {
                chC.Checked = true;

            }
            if (txtD.Text.CompareTo(choose[position]) == 0)
            {
                chD.Checked = true;

            }

            if (xong == 1)
            {
                if (choose[position].CompareTo(dung[position]) == 0)
                {
                    txtYES.Text = "ĐÚNG";
                    txtYES.ForeColor = Color.Green;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Green;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }
                }
                else
                {
                    txtYES.Text = "SAI";
                    txtYES.ForeColor = Color.Red;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Red;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }

                    if (txtA.Text.CompareTo(dung[position]) == 0)
                        txtA.ForeColor = Color.Green;

                    if (txtB.Text.CompareTo(dung[position]) == 0)
                        txtB.ForeColor = Color.Green;

                    if (txtC.Text.CompareTo(dung[position]) == 0)
                        txtC.ForeColor = Color.Green;

                    if (txtD.Text.CompareTo(dung[position]) == 0)
                        txtD.ForeColor = Color.Green;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if (position == n-1)
            //    return;

            //if (position == n-2)
            //    btnNext.Enabled = false;

            btnBack.Enabled = true;

            if (chA.Checked == true)
                choose[position] = txtA.Text;
            if (chB.Checked == true)
                choose[position] = txtB.Text;
            if (chC.Checked == true)
                choose[position] = txtC.Text;
            if (chD.Checked == true)
                choose[position] = txtD.Text;

            if (txtSoCau.Text.Length == 0 && position == n - 1 || txtSoCau.Text.Length > 0 && position == int.Parse(txtSoCau.Text) -1)
                position = -1;

            position++;
            txtGo.Text = (position + 1).ToString();
            int x = position + 1;
            txtCauHoiSo.Text = "CÂU SỐ " + x;
            txtCH.Text = ch[position];
            txtA.Text = a[position];
            txtB.Text = b[position];
            txtC.Text = c[position];
            txtD.Text = d[position];

            if (txtA.Text.CompareTo(choose[position]) == 0)
            {
                chA.Checked = true;
            }
            else
            if (txtB.Text.CompareTo(choose[position]) == 0)
            {
                chB.Checked = true;
            }
            else
            if (txtC.Text.CompareTo(choose[position]) == 0)
            {
                chC.Checked = true;

            }
            else
            if (txtD.Text.CompareTo(choose[position]) == 0)
            {
                chD.Checked = true;

            }
           

            if (xong == 1)
            {
                if (choose[position].CompareTo(dung[position]) == 0)
                {
                    txtYES.Text = "ĐÚNG";
                    txtYES.ForeColor = Color.Green;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Green;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }
                }
                else
                {
                    txtYES.Text = "SAI";
                    txtYES.ForeColor = Color.Red;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Red;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }

                    if (txtA.Text.CompareTo(dung[position]) == 0)
                        txtA.ForeColor = Color.Green;

                    if (txtB.Text.CompareTo(dung[position]) == 0)
                        txtB.ForeColor = Color.Green;

                    if (txtC.Text.CompareTo(dung[position]) == 0)
                        txtC.ForeColor = Color.Green;

                    if (txtD.Text.CompareTo(dung[position]) == 0)
                        txtD.ForeColor = Color.Green;
                }
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if (n == 0)
                return;

            if (txtGo.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vị trí số câu bạn cần đến...");
                txtGo.Focus();
                txtGo.Text = (position + 1).ToString();
                return;
            }

            for (int i=0;i<txtGo.Text.Length;i++)
            {
                if (txtGo.Text[i] < '0' || txtGo.Text[i] > '9')
                {
                    MessageBox.Show("Vui lòng nhập trường dữ liệu cần thiết là một số nguyên! ");
                    txtGo.Focus();
                    txtGo.Text = (position+1).ToString();
                    return;
                }
            }

            int xx = int.Parse(txtGo.Text);

            if (txtSoCau.Text.Length == 0)
            {
                if (xx < 1 || xx > n)
                {
                    MessageBox.Show("Vui lòng nhập chính xác vị trí câu hỏi cần xem (khả dụng từ 1 đến " + n + ")");
                    txtGo.Focus();
                    txtGo.Text = (position + 1).ToString();
                    return;
                }
            }
            else
            {
                if (xx < 1 || xx > int.Parse(txtSoCau.Text))
                {
                    MessageBox.Show("Vui lòng nhập chính xác vị trí câu hỏi cần xem (khả dụng từ 1 đến " + txtSoCau.Text + ")");
                    txtGo.Focus();
                    txtGo.Text = (position + 1).ToString();
                    return;
                }
            }

            if (chA.Checked == true)
                choose[position] = txtA.Text;
            if (chB.Checked == true)
                choose[position] = txtB.Text;
            if (chC.Checked == true)
                choose[position] = txtC.Text;
            if (chD.Checked == true)
                choose[position] = txtD.Text;

            position = int.Parse(txtGo.Text) - 1;
            txtGo.Text = (position + 1).ToString();

            if (position == n - 1)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = true;
            }
            else if (position == 0)
            {
                btnNext.Enabled = true;
                btnBack.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
            }
           
            int x = position + 1;
            txtCauHoiSo.Text = "CÂU SỐ " + x;
            txtCH.Text = ch[position];
            txtA.Text = a[position];
            txtB.Text = b[position];
            txtC.Text = c[position];
            txtD.Text = d[position];

            if (txtA.Text.CompareTo(choose[position]) == 0)
            {
                chA.Checked = true;
            }
            if (txtB.Text.CompareTo(choose[position]) == 0)
            {
                chB.Checked = true;
            }
            if (txtC.Text.CompareTo(choose[position]) == 0)
            {
                chC.Checked = true;

            }
            if (txtD.Text.CompareTo(choose[position]) == 0)
            {
                chD.Checked = true;

            }

            txtCH.Focus();

            if (xong == 1)
            {
                if (choose[position].CompareTo(dung[position]) == 0)
                {
                    txtYES.Text = "ĐÚNG";
                    txtYES.ForeColor = Color.Green;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Green;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }
                }
                else
                {
                    txtYES.Text = "SAI";
                    txtYES.ForeColor = Color.Red;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Red;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }

                    if (txtA.Text.CompareTo(dung[position]) == 0)
                        txtA.ForeColor = Color.Green;

                    if (txtB.Text.CompareTo(dung[position]) == 0)
                        txtB.ForeColor = Color.Green;

                    if (txtC.Text.CompareTo(dung[position]) == 0)
                        txtC.ForeColor = Color.Green;

                    if (txtD.Text.CompareTo(dung[position]) == 0)
                        txtD.ForeColor = Color.Green;
                }
            }
            btnBack.Enabled = true;
            btnNext.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc bài kiểm tra hiện tại này không?\n\n[LƯU Ý : Không nên nhấn bất kỳ phím nào trên máy của bạn để tránh xảy ra sự cố, thay vào đó hãy tự sử dụng chuột và trỏ click một trong hai lựa chọn YES/NO trên hộp thoại này]\n", "CẢNH BÁO!",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;


            btnAgain.Visible = true;
            btnNew.Visible = true;


            timer.Stop();
            xong = 1;
            chA.Enabled = false;
            chB.Enabled = false;
            chC.Enabled = false;
            chD.Enabled = false;
            btnEnd.Enabled = false;

            btnSAI.Visible = true;

            if (chA.Checked == true)
                choose[position] = txtA.Text;
            if (chB.Checked == true)
                choose[position] = txtB.Text;
            if (chC.Checked == true)
                choose[position] = txtC.Text;
            if (chD.Checked == true)
                choose[position] = txtD.Text;

            position = 0;
            btnNext.Enabled = true;


            txtGo.Text = (position + 1).ToString();
            int x = position + 1;
            txtCauHoiSo.Text = "CÂU SỐ " + x;
            txtCH.Text = ch[position];
            txtA.Text = a[position];
            txtB.Text = b[position];
            txtC.Text = c[position];
            txtD.Text = d[position];

            if (txtA.Text.CompareTo(choose[position]) == 0)
            {
                chA.Checked = true;
            }
            if (txtB.Text.CompareTo(choose[position]) == 0)
            {
                chB.Checked = true;
            }
            if (txtC.Text.CompareTo(choose[position]) == 0)
            {
                chC.Checked = true;

            }
            if (txtD.Text.CompareTo(choose[position]) == 0)
            {
                chD.Checked = true;

            }

            if (choose[position].CompareTo(dung[position]) == 0)
            {
                txtYES.Text = "ĐÚNG";
                txtYES.ForeColor = Color.Green;

                if (chA.Checked == true)
                {
                    txtA.ForeColor = Color.Green;
                    txtB.ForeColor = Color.Black;
                    txtC.ForeColor = Color.Black;
                    txtD.ForeColor = Color.Black;
                }

                if (chB.Checked == true)
                {
                    txtB.ForeColor = Color.Green;
                    txtA.ForeColor = Color.Black;
                    txtC.ForeColor = Color.Black;
                    txtD.ForeColor = Color.Black;
                }

                if (chC.Checked == true)
                {
                    txtC.ForeColor = Color.Green;
                    txtB.ForeColor = Color.Black;
                    txtA.ForeColor = Color.Black;
                    txtD.ForeColor = Color.Black;
                }

                if (chD.Checked == true)
                {
                    txtD.ForeColor = Color.Green;
                    txtB.ForeColor = Color.Black;
                    txtC.ForeColor = Color.Black;
                    txtA.ForeColor = Color.Black;
                }
            }
            else
            {
                txtYES.Text = "SAI";
                txtYES.ForeColor = Color.Red;

                if (chA.Checked == true)
                {
                    txtA.ForeColor = Color.Red;
                    txtB.ForeColor = Color.Black;
                    txtC.ForeColor = Color.Black;
                    txtD.ForeColor = Color.Black;
                }

                if (chB.Checked == true)
                {
                    txtB.ForeColor = Color.Red;
                    txtA.ForeColor = Color.Black;
                    txtC.ForeColor = Color.Black;
                    txtD.ForeColor = Color.Black;
                }

                if (chC.Checked == true)
                {
                    txtC.ForeColor = Color.Red;
                    txtB.ForeColor = Color.Black;
                    txtA.ForeColor = Color.Black;
                    txtD.ForeColor = Color.Black;
                }

                if (chD.Checked == true)
                {
                    txtD.ForeColor = Color.Red;
                    txtB.ForeColor = Color.Black;
                    txtC.ForeColor = Color.Black;
                    txtA.ForeColor = Color.Black;
                }

                if (txtA.Text.CompareTo(dung[position]) == 0)
                    txtA.ForeColor = Color.Green;

                if (txtB.Text.CompareTo(dung[position]) == 0)
                    txtB.ForeColor = Color.Green;

                if (txtC.Text.CompareTo(dung[position]) == 0)
                    txtC.ForeColor = Color.Green;

                if (txtD.Text.CompareTo(dung[position]) == 0)
                    txtD.ForeColor = Color.Green;
            }
            txtDiem.Visible = true;

            int dem = 0;

            if (txtSoCau.Text.Length == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (dung[i].CompareTo(choose[i]) == 0)
                    {
                        dem++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < int.Parse(txtSoCau.Text); i++)
                {
                    if (dung[i].CompareTo(choose[i]) == 0)
                    {
                        dem++;
                    }
                }
            }

            double diem = 0;
            if (txtSoCau.Text.Length == 0)
            diem = ((double) 10 / (double) n) * dem;
            else
                diem = ((double)10 / (double) int.Parse(txtSoCau.Text)) * dem;

            diem = Math.Round(diem, 1);
                txtDiem.Text = "ĐIỂM CỦA BẠN : " + diem;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSAI_Click(object sender, EventArgs e)
        {
            String s = "";
            int d = 0;

            int zn = 0;
            if (txtSoCau.Text.Length == 0)
                zn = n;
            else
                zn = int.Parse(txtSoCau.Text);
            for (int i=0;i<zn;i++)
            {
                if (dung[i].CompareTo(choose[i]) != 0)
                {
                    s = s + (i + 1) + ", ";
                    d++;
                }
            }
            if (d == 0)
                MessageBox.Show("Chúc mừng, bạn đã thực hiện đúng hết các câu hỏi !");
            else
            MessageBox.Show("Sau đây là những câu hỏi mà bạn đã thực hiện sai đáp án :\n\n" + s + "\n\n[Số câu sai : "+d+" / "+zn+" || Số câu đúng : "+(zn-d)+" / " + zn + "]");
            txtCH.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();

            int h = int.Parse((timeX / 3600).ToString());
            int m = int.Parse(((timeX / 60) % 60).ToString());
            int s = int.Parse((timeX % 60).ToString());

           if (h< 10 && m < 10 && s < 10)
                txtTick.Text = "0" + h + " : 0" + m + " : 0" + s;
            if (h < 10 && m < 10 && s >= 10)
                txtTick.Text = "0" + h + " : 0" + m + " : " + s;
            if (h < 10 && m >= 10 && s < 10)
                txtTick.Text = "0" + h + " : " + m + " : 0" + s;
            if (h < 10 && m >= 10 && s >= 10)
                txtTick.Text = "0" + h + " : " + m + " : " + s;
            if (h >= 10 && m < 10 && s < 10)
                txtTick.Text = "" + h + " : 0" + m + " : 0" + s;
            if (h >= 10 && m < 10 && s >= 10)
                txtTick.Text = "" + h + " : 0" + m + " : " + s;
            if (h >= 10 && m >= 10 && s < 10)
                txtTick.Text = "" + h + " : " + m + " : 0" + s;
            if (h >=10 && m >= 10 && s >= 10)
                txtTick.Text = "" + h + " : " + m + " : " + s;

            timeX--;

            if (timeX == -1)
            {
                timer.Stop();
                MessageBox.Show("Đã hết thời gian làm bài !");


                btnAgain.Visible = true;
                btnNew.Visible = true;

                xong = 1;
                chA.Enabled = false;
                chB.Enabled = false;
                chC.Enabled = false;
                chD.Enabled = false;
                btnEnd.Enabled = false;

                btnSAI.Visible = true;

                if (chA.Checked == true)
                    choose[position] = txtA.Text;
                if (chB.Checked == true)
                    choose[position] = txtB.Text;
                if (chC.Checked == true)
                    choose[position] = txtC.Text;
                if (chD.Checked == true)
                    choose[position] = txtD.Text;

                position = 0;
                btnNext.Enabled = true;


                txtGo.Text = (position + 1).ToString();
                int x = position + 1;
                txtCauHoiSo.Text = "CÂU SỐ " + x;
                txtCH.Text = ch[position];
                txtA.Text = a[position];
                txtB.Text = b[position];
                txtC.Text = c[position];
                txtD.Text = d[position];

                if (txtA.Text.CompareTo(choose[position]) == 0)
                {
                    chA.Checked = true;
                }
                if (txtB.Text.CompareTo(choose[position]) == 0)
                {
                    chB.Checked = true;
                }
                if (txtC.Text.CompareTo(choose[position]) == 0)
                {
                    chC.Checked = true;

                }
                if (txtD.Text.CompareTo(choose[position]) == 0)
                {
                    chD.Checked = true;

                }

                if (choose[position].CompareTo(dung[position]) == 0)
                {
                    txtYES.Text = "ĐÚNG";
                    txtYES.ForeColor = Color.Green;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Green;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Green;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }
                }
                else
                {
                    txtYES.Text = "SAI";
                    txtYES.ForeColor = Color.Red;

                    if (chA.Checked == true)
                    {
                        txtA.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chB.Checked == true)
                    {
                        txtB.ForeColor = Color.Red;
                        txtA.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chC.Checked == true)
                    {
                        txtC.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                        txtD.ForeColor = Color.Black;
                    }

                    if (chD.Checked == true)
                    {
                        txtD.ForeColor = Color.Red;
                        txtB.ForeColor = Color.Black;
                        txtC.ForeColor = Color.Black;
                        txtA.ForeColor = Color.Black;
                    }

                    if (txtA.Text.CompareTo(dung[position]) == 0)
                        txtA.ForeColor = Color.Green;

                    if (txtB.Text.CompareTo(dung[position]) == 0)
                        txtB.ForeColor = Color.Green;

                    if (txtC.Text.CompareTo(dung[position]) == 0)
                        txtC.ForeColor = Color.Green;

                    if (txtD.Text.CompareTo(dung[position]) == 0)
                        txtD.ForeColor = Color.Green;
                }

                txtDiem.Visible = true;

                int dem = 0;
                for (int i = 0; i < n; i++)
                {
                    if (dung[i].CompareTo(choose[i]) == 0)
                    {
                        dem++;
                    }
                }

                double diem = ((double)10 / (double)n) * dem;
                diem = Math.Round(diem, 1);
                txtDiem.Text = "ĐIỂM CỦA BẠN : " + diem;
                btnBack.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void txtCauHoiSo_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                txtFile.Text = fileName;
                txtFile.Focus();
            }
            else
                txtFile.Focus();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {

            timeX = 60 * int.Parse(txtTime.Text);
           
            

            btnOK.Enabled = false;
            btnEnd.Enabled = true;
            btnGO.Enabled = true;
            if (n > 1)
                btnNext.Enabled = true;

            xong = 0;

            position = 0;

            int xx = position + 1;
        

            btnBack.Enabled = false;

            String file = ND_file;
            String[] split = { "\n#\n" };
            String[] t1 = file.Split(split, StringSplitOptions.RemoveEmptyEntries);

            ch = new String[n];
            a = new String[n];
            b = new String[n];
            c = new String[n];
            d = new String[n];
            dung = new String[n];
            choose = new String[n];

            chuaxet_ch = new int[n];

            chuaxet_da = new int[n][];
            for (int i = 0; i < n; i++)
                chuaxet_da[i] = new int[5];

            //for (int i = 0; i < t1.Length; i++)
            //{
            //    String[] t2 = t1[i].Split('\n');
            //    ch[i] = t2[0];
            //    a[i] = t2[1];
            //    b[i] = t2[2];
            //    c[i] = t2[3];
            //    d[i] = t2[4];
            //    dung[i] = t2[5];
            //}



            int dem = 0;
            while (true)
            {
                if (dem == n)
                    break;


                Random r = new Random();
                double x = r.Next(0, n);

                if (chuaxet_ch[int.Parse(x.ToString())] == 1)
                    continue;

                chuaxet_ch[int.Parse(x.ToString())] = 1;
                int i = int.Parse(x.ToString());
                String[] t2 = t1[i].Split('\n');

                char[] CH = t2[0].ToCharArray();

                if (CH[0] == '$')
                {
                    String x0 = t2[0].Remove(0, 1);
                    ch[dem] = x0;
                    a[dem] = t2[1];
                    b[dem] = t2[2];
                    c[dem] = t2[3];
                    d[dem] = t2[4];
                    String DAx = t2[5].Replace("[", "");
                    DAx = DAx.Replace("]", "");
                    dung[dem] = DAx;
                }
                else
                {
                    int aa, bb, cc, dd;

                    ch[dem] = t2[0];

                    do
                    {
                        aa = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(aa.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(aa.ToString())] = 1;


                    a[dem] = t2[aa];

                    do
                    {
                        bb = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(bb.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(bb.ToString())] = 1;


                    b[dem] = t2[bb];

                    do
                    {
                        cc = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(cc.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(cc.ToString())] = 1;

                    c[dem] = t2[cc];

                    do
                    {
                        dd = r.Next(1, 5);
                    }
                    while (chuaxet_da[dem][int.Parse(dd.ToString())] == 1);
                    chuaxet_da[dem][int.Parse(dd.ToString())] = 1;

                    d[dem] = t2[dd];

                    String DA = t2[5].Replace("[", "");
                    DA = DA.Replace("]", "");

                    dung[dem] = DA;
                }

                dem++;
            }

            for (int i = 0; i < n; i++)
            {
                choose[i] = a[i];
            }
            MessageBox.Show("Bắt đầu - đã sẵn sàng làm bài kiểm tra trắc nghiệm ! ");
            txtTime.ReadOnly = true;
            txtFile.ReadOnly = true;
            txtDiem.Text = "";
            btnAgain.Visible = false;
            btnNew.Visible = false;
            btnSAI.Visible = false;
            //chA.Checked = true;
            chA.Enabled = true;
            chB.Enabled = true;
            chC.Enabled = true;
            chD.Enabled = true;
            // txtCauHoiSo.Text

            txtYES.Text = "";
            txtA.ForeColor = Color.Black;
            txtB.ForeColor = Color.Black;
            txtC.ForeColor = Color.Black;
            txtD.ForeColor = Color.Black;
            txtGo.Text = "1";
            chA.Checked = true;
            txtCauHoiSo.Text = "CÂU SỐ " + xx;
            txtCH.Text = ch[position];
            txtA.Text = a[position];
            txtB.Text = b[position];
            txtC.Text = c[position];
            txtD.Text = d[position];
            timer1_Tick(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            btnEnd.Enabled = true;
            btnGO.Enabled = true;
            if (n > 1)
                btnNext.Enabled = true;

            ND_file = "";

            txtTime.ReadOnly = true;
            txtFile.ReadOnly = true;
            txtDiem.Text = "";
            btnAgain.Visible = false;
            btnNew.Visible = false;
            btnSAI.Visible = false;
            chA.Checked = true;
            chA.Enabled = true;
            chB.Enabled = true;
            chC.Enabled = true;
            chD.Enabled = true;
            // txtCauHoiSo.Text

            txtYES.Text = "";
            txtA.ForeColor = Color.Black;
            txtB.ForeColor = Color.Black;
            txtC.ForeColor = Color.Black;
            txtD.ForeColor = Color.Black;

            xong = 0;

            txtNameCH.Text = "";

            position = 0;

            txtCauHoiSo.Text = "CÂU SỐ 1";
            btnChooseFile.Enabled = true;
            btnOK.Enabled = true;
            txtA.Text = "";
            txtB.Text = "";
            txtCH.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtGo.Text = "1";

            txtFile.ReadOnly = false;
            txtTime.ReadOnly = false;
            txtSoCau.ReadOnly = false;

            btnGO.Enabled = false;

            txtFile.Text = "";
            txtTime.Text = "";
            txtSoCau.Text = "";
            btnEnd.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            txtTick.Text = "00 : 00 : 00";
            n = 0;
            txtFile.Focus();
            chA.Enabled = false;
            chB.Enabled = false;
            chC.Enabled = false;
            chD.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String x = "[LUAT]";
            txtTime.Text = x.Length.ToString();
            //  int n = x.Length;
            txtFile.Text = x.Substring(1, x.Length - 2);
        }

        private void txtCH_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmX_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.ReadOnly == true)
            {
                txtCH.Focus();
                return;
            }
                

            if (e.KeyCode == Keys.Enter)
            {
                if (txtFile.Text == "")
                    btnChooseFile_Click(sender, e);
                else
                    txtTime.Focus();
            }
         }

        private void txtTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTime.ReadOnly == true)
            {
                txtCH.Focus();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void txtGo_KeyDown(object sender, KeyEventArgs e)
        {
            if (n == 0 && txtFile.Text.Length > 0)
            {
                txtFile.Focus();
                return;
            }

           



            if (e.KeyCode == Keys.Enter)
            {
                if (btnGO.Enabled == true)
                    btnGO_Click(sender, e);
                else
                    btnChooseFile_Click(sender, e);
            }
        }

        private void txtCH_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);


            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                    btnNext_Click(sender, e);
            }
               
        }

        private void chA_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void chB_CheckedChanged(object sender, EventArgs e)
        {
            txtCH.Focus();
        }

        private void chB_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtA_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void chC_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtC_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void chD_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtD_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void txtD_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnAgain_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnSAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFile.Text == "")
            {
                btnChooseFile_Click(sender, e);
                return;
            }

            if (txtTime.Text == "")
            {
                txtTime.Focus();
                return;
            }

            if (e.KeyCode == Keys.X && xong == 1)
                btnAgain_Click(sender, e);

            if (e.KeyCode == Keys.P && xong == 1)
                btnNew_Click(sender, e);

            if (e.KeyCode == Keys.L)
                txtGo.Focus();

            if (e.KeyCode == Keys.Space)
                btnBack_Click(sender, e);

            if (e.KeyCode == Keys.S && xong == 1)
                btnSAI_Click(sender, e);

            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnSAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtGo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGO_KeyDown(object sender, KeyEventArgs e)
        {
            if (xong == 0)
            {
                if (e.KeyCode == Keys.A)
                    chA.Checked = true;

                if (e.KeyCode == Keys.B)
                    chB.Checked = true;

                if (e.KeyCode == Keys.C)
                    chC.Checked = true;

                if (e.KeyCode == Keys.D)
                    chD.Checked = true;
            }

            if (e.KeyCode == Keys.Enter && n > 0)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void chA_CheckedChanged(object sender, EventArgs e)
        {
            txtCH.Focus();
        }

        private void chC_CheckedChanged(object sender, EventArgs e)
        {
            txtCH.Focus();
        }

        private void chD_CheckedChanged(object sender, EventArgs e)
        {
            txtCH.Focus();
        }

        private void btnChooseFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCH_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void txtAN_Click(object sender, EventArgs e)
        {
            if (txtAN.Text == "[X]")
            {
                txtAN.Text = "[?]";
                txtAN.ForeColor = Color.Green;
                txtKey.Visible = false;
            }
            else
            {
                txtAN.Text = "[X]";
                txtAN.ForeColor = Color.Red;
                txtKey.Visible = true;
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtTime_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtTime.ReadOnly == true || e.KeyCode == Keys.Back)
                return;

            if (e.KeyValue < '0' || e.KeyValue > '9')
                txtTime.Text = "";
        }

        private void txtGo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtGo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Back)
                return;

            if (e.KeyValue < '0' || e.KeyValue > '9')
                txtGo.Text = (position + 1).ToString();
        }
    }
 }
    