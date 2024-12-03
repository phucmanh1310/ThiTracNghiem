using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;
using static System.Formats.Asn1.AsnWriter;

namespace DoAn_ThiTracNghiem
{
    public partial class frmExamination : Form
    {
        private int timeleft;
        private string username;
        private int currentQuestionIndex = 0;
        private Dictionary<string, int> userAnswers = new Dictionary<string, int>();

        private ThiSinhBLL thiSinhBBL = new ThiSinhBLL();
        private CauHoiBBL cauHoiBBL = new CauHoiBBL();
        private DapAnBBL dapAnBBL = new DapAnBBL();
        private KetQuaBLL ketQuaBLL = new KetQuaBLL();

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
            var listCauHoi = cauHoiBBL.GetCauHoi();
            var currentQuestion = listCauHoi[currentQuestionIndex];
            lbCauHoi.Text = $"Câu {currentQuestionIndex + 1}: {currentQuestion.NDCauHoi}";
            DisplayQuestionImage(currentQuestion.HinhAnh);
            DisplayAnswerChoices(currentQuestion.MaCauHoi);
        }

        private void DisplayQuestionImage(string imagePath)
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

        private void DisplayAnswerChoices(string maCauHoi)
        {
            var listDapAn = dapAnBBL.GetDapAn(maCauHoi);
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4 };

            for (int i = 0; i < listDapAn.Count; i++)
            {
                var answer = listDapAn[i];
                radioButtons[i].Text = answer.NDCauTraLoi;
                radioButtons[i].Tag = answer.MaCauTraLoi;
                radioButtons[i].Visible = true;
                radioButtons[i].Checked = userAnswers.ContainsKey(currentQuestionIndex.ToString()) && userAnswers[currentQuestionIndex.ToString()] == (int)radioButtons[i].Tag;
                radioButtons[i].CheckedChanged -= RadioButton_CheckedChanged;
                radioButtons[i].CheckedChanged += RadioButton_CheckedChanged;
            }

            for (int i = listDapAn.Count; i < radioButtons.Length; i++)
            {
                radioButtons[i].Visible = false;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                userAnswers[currentQuestionIndex.ToString()] = (int)radioButton.Tag;
            }
        }

        private void ButtonCauHoi_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            currentQuestionIndex = int.Parse(btn.Name.Replace("btnCau", "")) - 1;
            HienThiCauHoi();
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
                if (userAnswers.ContainsKey(cauHoi.MaCauHoi))
                {
                    var selectedAnswer = userAnswers[cauHoi.MaCauHoi];
                    if (dapAnBBL.IsCorrectAnswer(cauHoi.MaCauHoi, selectedAnswer))
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
            bool isSaved = ketQuaBLL.LuuKetQua(ketQua);

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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                HienThiCauHoi();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < 24) // Kiểm tra không vượt quá số câu hỏi
            {
                currentQuestionIndex++;
                HienThiCauHoi();
            }
        }
    }
}
