using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DoAn_ThiTracNghiem
{
    public partial class frmExamination : Form
    {
        private int timeleft;
        private string username;
        private int CauHoiHienTai = 0;
        public Dictionary<int, int?> DapAnDaChon = new Dictionary<int, int?>();
        

        private ThiSinhBLL thiSinhBBL = new ThiSinhBLL();
        private CauHoiBLL cauHoiBBL = new CauHoiBLL();
        private DapAnBBL dapAnBBL = new DapAnBBL();
        private KetQuaBLL ketQuaBLL = new KetQuaBLL();
        private List<CauHoi> listCauHoi;

        public frmExamination(string username)
        {
            InitializeComponent();
            this.username = username;
            listCauHoi = cauHoiBBL.GetCauHoi();
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

            // Đăng ký sự kiện CheckedChanged chỉ một lần
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void HienThiHinhAnh(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBoxCauHoi.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxCauHoi.Image = null;
            }
        }

        private void HienThiCauHoi()
        {
            var cauHoiHienTai = listCauHoi[CauHoiHienTai];
            lbCauHoi.Text = $"Câu {CauHoiHienTai + 1}: {cauHoiHienTai.NDCauHoi}";
            HienThiHinhAnh(cauHoiHienTai.HinhAnh);
            HienThiDapAn(cauHoiHienTai.MaCauHoi);
        }

        private void HienThiDapAn(int maCauHoi)
        {
            var listDapAn = dapAnBBL.GetDapAn(maCauHoi);
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4 };

            // Đặt lại trạng thái cho tất cả RadioButton về "unchecked"
            foreach (var radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            // Cập nhật các đáp án vào RadioButton
            for (int i = 0; i < listDapAn.Count; i++)
            {
                radioButtons[i].Text = listDapAn[i].NDCauTraLoi;
                radioButtons[i].Tag = listDapAn[i].MaCauTraLoi;

                // Nếu người dùng đã trả lời câu hỏi này, đánh dấu đáp án đã chọn
                if (DapAnDaChon.ContainsKey(maCauHoi) && DapAnDaChon[maCauHoi] == listDapAn[i].MaCauTraLoi)
                {
                    radioButtons[i].Checked = true; // Đánh dấu RadioButton đã được chọn
                }
            }

            // Ẩn các radio button không sử dụng (nếu ít hơn 4 đáp án)
            for (int i = listDapAn.Count; i < radioButtons.Length; i++)
            {
                radioButtons[i].Visible = false;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadio = (RadioButton)sender;
            int maCauTraLoi = (int)selectedRadio.Tag;
            int maCauHoi = listCauHoi[CauHoiHienTai].MaCauHoi;

            // Lưu đáp án vào DapAnDaChon khi người dùng thay đổi lựa chọn
            if (selectedRadio.Checked)
            {
                DapAnDaChon[maCauHoi] = maCauTraLoi;
            }
        }

        private void ButtonCauHoi_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            CauHoiHienTai = int.Parse(btn.Name.Replace("btnCau", "")) - 1;
            HienThiCauHoi();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CauHoiHienTai > 0)
            {
                CauHoiHienTai--;
                HienThiCauHoi();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CauHoiHienTai < listCauHoi.Count - 1) // Kiểm tra không vượt quá số câu hỏi
            {
                CauHoiHienTai++;
                HienThiCauHoi();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn nộp bài chứ?", "Nộp bài!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Submit();
            }
        }

        private void Submit()
        {
            timer1.Stop();

            // Tính điểm
            var listCauHoi = cauHoiBBL.GetCauHoi();
            int score = 0;

            foreach (var cauHoi in listCauHoi)
            {
                if (DapAnDaChon.ContainsKey(cauHoi.MaCauHoi))
                {
                    var selectedAnswer = DapAnDaChon[cauHoi.MaCauHoi];
                    if (dapAnBBL.IsCorrectAnswer(cauHoi.MaCauHoi, selectedAnswer.Value))
                    {
                        score++;
                    }
                }
            }

            // Lấy thông tin thí sinh và lần thi hiện tại
            ThiSinh thiSinh = thiSinhBBL.GetThiSinh(username);
            int lanThi = ketQuaBLL.GetLanThi(thiSinh.MaThiSinh);

            // Tạo đối tượng kết quả
            KetQua ketQua = new KetQua
            {
                LanThi = lanThi + 1, // Tăng lần thi lên 1
                KetQuaThi = $"{score}/{listCauHoi.Count}", // Điểm số dạng x/y
                MaThiSinh = thiSinh.MaThiSinh,
                ThoiGian = 15 * 60 - timeleft // Tính thời gian đã làm bài
            };

            // Lưu kết quả thi
            bool isSaved = ketQuaBLL.LuuKetQua(ketQua, DapAnDaChon);

            if (isSaved)
            {
                MessageBox.Show($"Bạn đã nộp bài thành công!\nĐiểm số: {score}/{listCauHoi.Count}\nThời gian làm bài: {FormatTime(ketQua.ThoiGian)}",
                                "Nộp bài thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu kết quả. Vui lòng thử lại.",
                                "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đóng form hoặc trở về giao diện chính
            this.Close();
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
    }
}
