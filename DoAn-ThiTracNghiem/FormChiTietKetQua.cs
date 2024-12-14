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

namespace DoAn_ThiTracNghiem
{
    public partial class FormChiTietKetQua : Form
    {
        
        private int maKetQua;
        private int CauHoiHienTai = 0;
        DapAnBBL daBLL = new DapAnBBL();
        CauHoiBLL chBLL = new CauHoiBLL();
        private List<int> listMaCauHoi;
        ChiTietKetQuaBLL ctkqBLL = new ChiTietKetQuaBLL();


        public FormChiTietKetQua(int maKetQua)
        {
            InitializeComponent();
            this.maKetQua = maKetQua;
            listMaCauHoi = chBLL.GetMaCauHoiByMaKetQua(maKetQua);

            HienThiCauHoi();

        }

        private void FormChiTietKetQua_Load(object sender, EventArgs e)
        {

            TaoButtonCauHoi();
            
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
            // Chuyển câu hỏi (giả sử bạn đang giữ chỉ số câu hỏi hiện tại)
            if (CauHoiHienTai < listMaCauHoi.Count - 1)
            {
                CauHoiHienTai++;  // Tăng chỉ số câu hỏi lên
                HienThiCauHoi();     // Tải lại câu hỏi và đáp án

            }
        }

        /*private void HienThiCauHoi()
        {
            int maCauHoi = listMaCauHoi[CauHoiHienTai];

            CauHoi cauhoi = chBLL.GetCauHoiChiTietById(maCauHoi);

            lbCauHoi.Text = cauhoi.NDCauHoi;

            HienThiHinhAnh(cauhoi.HinhAnh);
            HienThiDapAn(maCauHoi);

            for (int i = 0; i < questionButtons.Count; i++)
            {
                var btnCauHoi = questionButtons[i];
            }
        }*/

        /*private void HienThiHinhAnh(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBoxCauHoi.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxCauHoi.Image = null;
            }
        }*/
        private void HienThiCauHoi()
        {
            if (listMaCauHoi == null || listMaCauHoi.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maCauHoi = listMaCauHoi[CauHoiHienTai];

            try
            {
                CauHoi cauhoi = chBLL.GetCauHoiChiTietById(maCauHoi);
                lbCauHoi.Text = $"Câu {CauHoiHienTai + 1}: {cauhoi.NDCauHoi}";
                HienThiHinhAnh(cauhoi.HinhAnh);
                HienThiDapAn(maCauHoi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị câu hỏi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiHinhAnh(string relativePath)
        {
            try
            {
                int maCauHoi = listMaCauHoi[CauHoiHienTai];
                var chiTietCauHoi = chBLL.GetCauHoiChiTietById(maCauHoi);
                // Hiển thị hình ảnh (nếu có)
                if (!string.IsNullOrEmpty(chiTietCauHoi.HinhAnh))
                {
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", chiTietCauHoi.HinhAnh);

                    if (File.Exists(imagePath))
                    {
                        pictureBoxCauHoi.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBoxCauHoi.Image = null;
                    }
                }
                else
                {
                    pictureBoxCauHoi.Image = null;
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDapAn(int maCauHoi)
        {
            int? macautraloi = daBLL.GetCauTraLoiByCauHoi(maCauHoi, maKetQua);

            var listDapAn = daBLL.GetDapAn(maCauHoi);
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4 };

            

            // Đặt lại trạng thái cho tất cả RadioButton về "unchecked"
            foreach (var radioButton in radioButtons)
            {
                radioButton.Checked = false;
                radioButton.Visible = true;
                radioButton.ForeColor = Color.Red;
            }

            // Cập nhật các đáp án vào RadioButton
            for (int i = 0; i < listDapAn.Count; i++)
            {
                radioButtons[i].Text = listDapAn[i].NDCauTraLoi;
                radioButtons[i].Tag = listDapAn[i].MaCauTraLoi;

                if (daBLL.IsCorrectAnswer(maCauHoi, listDapAn[i].MaCauTraLoi))
                {
                    radioButtons[i].ForeColor = Color.Green;
                }
            }

            // Ẩn các radio button không sử dụng (nếu ít hơn 4 đáp án)
            for (int i = listDapAn.Count; i < radioButtons.Length; i++)
            {
                radioButtons[i].Visible = false;
            }

            if (macautraloi.HasValue)
            {
                foreach (var radioButton in radioButtons)
                {
                    if (radioButton.Tag != null && (int)radioButton.Tag == macautraloi.Value)
                    {
                        radioButton.Checked = true;  // Đánh dấu RadioButton đã chọn
                        break;
                    }
                }
            }


        }

        //private Button GetButtonForQuestion(int index)  // Định nghĩa phương thức này
        //{
        //    // Lấy Button tương ứng cho câu hỏi theo chỉ số index
        //    return questionButtons.FirstOrDefault(btn => btn.QuestionIndex == index)?.Button;
        //}

        private List<QuestionButton> questionButtons = new List<QuestionButton>();

        private void TaoButtonCauHoi()
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
                btn.Button.TextAlign = ContentAlignment.MiddleLeft; // Căn giữa nội dung trong button

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
                //UpdateQuestionStatus();  // Cập nhật lại màu sắc các nút
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
