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

        private void HienThiCauHoi()
        {
            int maCauHoi = listMaCauHoi[CauHoiHienTai];

            CauHoi cauhoi = chBLL.GetCauHoiChiTietById(maCauHoi);

            lbCauHoi.Text = cauhoi.NDCauHoi;

            HienThiHinhAnh(cauhoi.HinhAnh);
            HienThiDapAn(maCauHoi);
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

        private void HienThiDapAn(int maCauHoi)
        {
            int? macautraloi = daBLL.GetCauTraLoiByCauHoi(maCauHoi, maKetQua);

            var listDapAn = daBLL.GetDapAn(maCauHoi);
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
    }
}
