﻿using System;
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
        public Dictionary<int, int?> DapAnDaChon = new Dictionary<int, int?>();//1


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
            TaoDanhSachButtonCauHoi();

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

            // Cập nhật màu sắc cho các nút câu hỏi
            for (int i = 0; i < questionButtons.Count; i++)
            {
                var btnCauHoi = questionButtons[i];
                bool isAnswered = DapAnDaChon.ContainsKey(cauHoiHienTai.MaCauHoi) && DapAnDaChon[cauHoiHienTai.MaCauHoi] != null;
                btnCauHoi.SetSelected(isAnswered); // Đổi màu cho nút câu hỏi
            }
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
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CauHoiHienTai > 0)
            {
                CauHoiHienTai--;
                HienThiCauHoi();
                UpdateQuestionStatus();  // Cập nhật lại màu sắc các nút
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Chuyển câu hỏi (giả sử bạn đang giữ chỉ số câu hỏi hiện tại)
            if (CauHoiHienTai < listCauHoi.Count - 1)
            {
                CauHoiHienTai++;  // Tăng chỉ số câu hỏi lên
                HienThiCauHoi();     // Tải lại câu hỏi và đáp án
                UpdateQuestionStatus();  // Cập nhật lại trạng thái câu hỏi đã trả lời
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int soCauTraLoi = DapAnDaChon.Values.Count(value => value != null);
            int soCauChuaTraLoi = 25 - soCauTraLoi;
            if (MessageBox.Show($"Còn {soCauChuaTraLoi} câu hỏi chưa trả lời. Bạn chắc chắn nộp bài chứ?", "Nộp bài!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Submit();
            }
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
        //test
        private void Submit()
        {
            timer1.Stop();
            var listCauHoi = cauHoiBBL.GetCauHoi();

            // Tính điểm
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
                else
                {
                    DapAnDaChon[cauHoi.MaCauHoi] = null;
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

            ketQuaBLL.LuuKetQua(ketQua, DapAnDaChon);

            MessageBox.Show($"Bạn đã nộp bài thành công!\nĐiểm số: {score}/{listCauHoi.Count}\nThời gian làm bài: {FormatTime(ketQua.ThoiGian)}",
                                "Nộp bài thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadio = (RadioButton)sender;
            int maCauTraLoi = (int)selectedRadio.Tag;
            int maCauHoi = listCauHoi[CauHoiHienTai].MaCauHoi;

            if (selectedRadio.Checked)
            {
                DapAnDaChon[maCauHoi] = maCauTraLoi;

                // Cập nhật trạng thái câu hỏi là đã trả lời
                var cauHoi = listCauHoi.FirstOrDefault(c => c.MaCauHoi == maCauHoi);
                if (cauHoi != null)
                {
                    cauHoi.IsAnswered = true;
                }

                UpdateQuestionStatus(); // Cập nhật giao diện câu hỏi đã trả lời
            }
        }
        private void UpdateQuestionStatus()
        {
            for (int i = 0; i < listCauHoi.Count; i++)
            {
                var cauHoi = listCauHoi[i];
                Button btnCauHoi = GetButtonForQuestion(i);  // Lấy button câu hỏi

                // Kiểm tra xem câu hỏi đã được trả lời chưa và thay đổi màu sắc button
                if (DapAnDaChon.ContainsKey(cauHoi.MaCauHoi) && DapAnDaChon[cauHoi.MaCauHoi] != null)
                {
                    btnCauHoi.BackColor = Color.Green;  // Đã trả lời
                }
                else
                {
                    btnCauHoi.BackColor = Color.White;  // Chưa trả lời
                }
            }
        }
        private Button GetButtonForQuestion(int index)  // Định nghĩa phương thức này
        {
            // Lấy Button tương ứng cho câu hỏi theo chỉ số index
            return questionButtons.FirstOrDefault(btn => btn.QuestionIndex == index)?.Button;
        }


        private List<QuestionButton> questionButtons = new List<QuestionButton>();

        private void TaoDanhSachButtonCauHoi()
        {

            int buttonWidth = 35; // Kích thước button nhỏ hơn
            int buttonHeight = 35;
            int margin = 10; // Khoảng cách giữa các button
            int buttonsPerRow = 5; // Số button mỗi hàng

            // Cập nhật font size cho số trong button
            Font buttonFont = new Font("Arial", 10); // Thử tăng font size nếu cần

            for (int i = 0; i < 25; i++)
            {
                QuestionButton btn = new QuestionButton
                {
                    QuestionIndex = i,
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(11 + (i % 5) * 45, 48 + (i / 5) * 45), // Cập nhật lại vị trí nếu cần
                };

                btn.SetText((i + 1).ToString());

                // Đặt font và căn giữa văn bản trong button
                btn.Button.Font = buttonFont;
                btn.Button.TextAlign = ContentAlignment.MiddleCenter; // Căn giữa nội dung trong button

                btn.Button.Click += ButtonCauHoi_Click;
                questionButtons.Add(btn);
                groupBox3.Controls.Add(btn);
            }
        }


        private void ButtonCauHoi_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int questionNumber = int.Parse(clickedButton.Text);
                CauHoiHienTai = questionNumber - 1; // Tính toán lại câu hỏi hiện tại
                HienThiCauHoi(); // Hiển thị câu hỏi hiện tại
                UpdateQuestionStatus();  // Cập nhật lại màu sắc các nút
            }
        }

    }
}