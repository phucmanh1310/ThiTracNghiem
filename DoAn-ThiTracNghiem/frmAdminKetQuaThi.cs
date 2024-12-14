using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DoAn_ThiTracNghiem
{
    public partial class frmAdminKetQuaThi : Form
    {
        private int maThiSinh;
        private KetQuaBLL ketQuaBLL;
        private ThiSinhBLL thiSinhBLL;

        public frmAdminKetQuaThi(int maThiSinh)
        {
            InitializeComponent();
            this.maThiSinh = maThiSinh;
            ketQuaBLL = new KetQuaBLL();
            thiSinhBLL = new ThiSinhBLL();
        }

        private string GetHoTenThiSinh(int maThiSinh)
        {
            // Lấy họ và tên thí sinh
            return thiSinhBLL.GetHoTenTS(maThiSinh);
        }

        private void frnAdminKetQuaThi_Load(object sender, EventArgs e)
        {
            // Lấy danh sách kết quả thi
            List<KetQua> ketQuaList = ketQuaBLL.LayKetQuaChiTiet(maThiSinh);

            if (ketQuaList != null && ketQuaList.Count > 0)
            {
                // Hiển thị thông tin thí sinh
                string hoTenThiSinh = GetHoTenThiSinh(maThiSinh);
                txtHoTen.Text = hoTenThiSinh;
                txtMaTS.Text = maThiSinh.ToString();

                // Đổ danh sách lần thi vào ComboBox
                cmbLanThi.DataSource = ketQuaList;
                cmbLanThi.DisplayMember = "LanThi"; // Hiển thị lần thi
                cmbLanThi.ValueMember = "LanThi";  // Giá trị là số lần thi
            }
            else
            {
                // Nếu không có kết quả thi
                MessageBox.Show("Không có kết quả thi nào được tìm thấy cho thí sinh này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanThi.SelectedItem != null)
            {
                // Lấy đối tượng kết quả thi từ ComboBox
                KetQua ketQua = (KetQua)cmbLanThi.SelectedItem;

                if (ketQua != null)
                {
                    // Hiển thị thông tin chi tiết của lần thi
                    txtSTT.Text = ketQua.MaKetQua.ToString();       // Mã kết quả
                    txtThoiGian.Text = $"{ketQua.ThoiGian} giây";  // Thời gian làm bài
                    txtKetQua.Text = ketQua.KetQuaThi;            // Số câu đúng

                    // Hiển thị trạng thái đạt/không đạt từ cột `TrangThai`
                    if (ketQua.TrangThai == "Đạt")
                    {
                        lblKetQua.Text = "Kết Quả: Đạt";
                        lblKetQua.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblKetQua.Text = "Kết Quả: Không đạt";
                        lblKetQua.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin chi tiết cho lần thi này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Nếu không có kết quả thi
                if (cmbLanThi.Items.Count == 0)
                {
                    MessageBox.Show("Thí sinh này chưa có kết quả thi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose(); // Đóng form hiện tại
        }
    }
}
