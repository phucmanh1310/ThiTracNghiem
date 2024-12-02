using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_ThiTracNghiem
{
    public partial class frmExamination : Form
    {
        private int timeleft;
        private string username;
        ThiSinhBLL thiSinhBBL = new ThiSinhBLL();
        CauHoiBBL cauHoiBBL = new CauHoiBBL();
        DapAnBBL dapAnBBL = new DapAnBBL();
        private int cauHoiHienTai = 0;



        public frmExamination(string username)
        {
            InitializeComponent();
            this.username = username;
            HienThiCauHoi();
        }

        private void frmExamination_Load(object sender, EventArgs e)
        {
            timeleft = 15 * 60;
            lableTime.Text = FormatTime(timeleft);
            timer1.Start();

            ThiSinh thiSinh = thiSinhBBL.GetThiSinh(username);
            txtMaSo.Text = thiSinh.MaThiSinh.ToString();
            txtHoTen.Text = thiSinh.HoTenThiSinh;
        }

        private void HienThiCauHoi()
        {
            List<CauHoi> listCauHoi = cauHoiBBL.GetCauHoi();

            CauHoi cauHoi = listCauHoi[cauHoiHienTai];
            lbCauHoi.Text = $"Câu {cauHoiHienTai + 1}: {cauHoi.NDCauHoi}";

            if (!string.IsNullOrEmpty(cauHoi.HinhAnh))
            {
                string imagePath = cauHoi.HinhAnh; // Lấy đường dẫn đầy đủ từ database
                pictureBoxCauHoi.Image = Image.FromFile(imagePath); // Hiển thị ảnh
            }
            else
            {
                pictureBoxCauHoi.Image = null; // Xóa ảnh nếu không có
            }


            List<DapAn> listDapAn = dapAnBBL.GetDapAn(cauHoi.MaCauHoi);
            radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
            RadioButton[] radioButton = { radioButton1, radioButton2, radioButton3, radioButton4 };
            for (int i = 0; i < listDapAn.Count; i++)
            {
                radioButton[i].Text = listDapAn[i].NDCauTraLoi;
                radioButton[i].Tag = listDapAn[i].MaCauTraLoi; // Lưu mã câu trả lời trong Tag
                radioButton[i].Visible = true;

            }
        }

        private void ButtonCauHoi_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = int.Parse(btn.Name.Replace("btnCau", "")) - 1; // Lấy số từ tên button
            cauHoiHienTai = index;
            HienThiCauHoi();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn nộp bài chứ?", "Nộp bài!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Submit();
            }
        }

        void Submit()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                lableTime.Text = FormatTime(timeleft);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Phần thi đã hết giờ!", "Hết giờ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Submit();
            }
        }

        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            return $"{minutes:D2}:{remainingSeconds:D2}";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cauHoiHienTai > 0)
            {
                cauHoiHienTai--;
                HienThiCauHoi();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cauHoiHienTai < 24) // Kiểm tra không vượt quá số câu hỏi
            {
                cauHoiHienTai++;
                HienThiCauHoi();
            }
        }
    }
}