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
        private String GetHoTenThiSinh(int maThiSinh)
        {
            String hoVaTen = "";
            hoVaTen = thiSinhBLL.GetHoTenTS(maThiSinh);
            return hoVaTen;
        }
        private void frnAdminKetQuaThi_Load(object sender, EventArgs e)
        {
            // Lấy danh sách kết quả thi
            List<KetQua> ketQuaList = ketQuaBLL.LayKetQuaChiTiet(maThiSinh);
            if (ketQuaList != null && ketQuaList.Count > 0)
            {
                string hoTenThiSinh = GetHoTenThiSinh(maThiSinh);
                txtHoTen.Text = hoTenThiSinh;
                txtMaTS.Text = maThiSinh.ToString();

                // Đổ danh sách vào ComboBox
                cmbLanThi.DataSource = ketQuaList;
                cmbLanThi.DisplayMember = "LanThi"; // Hiển thị số lần thi
                cmbLanThi.ValueMember = "LanThi";     // Dùng STT làm giá trị
            }
            else
            {
                MessageBox.Show("Không có kết quả thi nào được tìm thấy cho thí sinh này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cmbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanThi.SelectedItem != null)
            {
                // Lấy đối tượng KetQua từ ComboBox
                KetQua ketQua = (KetQua)cmbLanThi.SelectedItem;

                if (ketQua != null)
                {
                    // Hiển thị thông tin chi tiết
                    txtSTT.Text = ketQua.STT.ToString();
                    txtThoiGian.Text = ketQua.ThoiGian.ToString();
                    txtKetQua.Text = ketQua.KetQuaThi;

                    // Kiểm tra kết quả thi
                    string ketQuaThi = ketQua.KetQuaThi; // Ví dụ: "21/25"
                    if (!string.IsNullOrEmpty(ketQuaThi) && ketQuaThi.Contains("/"))
                    {
                        string[] parts = ketQuaThi.Split('/');
                        int soCauDung = int.Parse(parts[0]); // Số câu đúng
                        int tongSoCau = int.Parse(parts[1]); // Tổng số câu

                        if (soCauDung >= 21)
                        {
                            lblKetQua.Text = "Kết Quả Đậu";
                            lblKetQua.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblKetQua.Text = "Kết Quả Rớt";
                            lblKetQua.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin chi tiết cho lần thi này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (cmbLanThi.Items.Count == 0)
                {
                    MessageBox.Show("Thí sinh này chưa có kết quả thi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

