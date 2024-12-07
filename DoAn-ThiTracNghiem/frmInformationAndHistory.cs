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
using Microsoft.VisualBasic;

namespace DoAn_ThiTracNghiem
{
    public partial class frmInformationAndHistory : Form
    {
        private string username;
        TaiKhoanBLL tkBBL = new TaiKhoanBLL();
        ThiSinhBLL tsBBL = new ThiSinhBLL();
        KetQuaBLL kqBLL = new KetQuaBLL();

        public frmInformationAndHistory(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void frmInformationAndHistory_Load(object sender, EventArgs e)
        {
            radioNam.Visible = false;
            radioNu.Visible = false;
            dtpNgaySinh.Visible = false;

            ThiSinh thiSinh = tsBBL.GetThiSinh(username);
            txtMaSo.Text = thiSinh.MaThiSinh.ToString();
            txtHoTen.Text = thiSinh.HoTenThiSinh ?? ""; // Tránh lỗi nếu HoTenThiSinh là null
            txtDiaChi.Text = thiSinh.DiaChi ?? ""; // Tránh lỗi nếu DiaChi là null
            txtGioiTinh.Text = thiSinh.GioiTinh.ToString() == "M" ? "Nam" : "Nữ";
            txtNgaySinh.Text = thiSinh.NgaySinh.ToString("dd/MM/yyyy");

            List<KetQua> listKQ = kqBLL.LayKetQuaChiTiet(thiSinh.MaThiSinh);
            foreach (var k in listKQ)
            {
                ListViewItem item = new ListViewItem(k.MaKetQua.ToString());
                item.SubItems.Add(k.LanThi.ToString());
                item.SubItems.Add(k.KetQuaThi);
                TimeSpan timeSpan = TimeSpan.FromSeconds(k.ThoiGian);
                item.SubItems.Add(timeSpan.ToString(@"mm\:ss"));

                listViewKetQua.Items.Add(item);
            }

        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            txtMaSo.ReadOnly = true;
            if (txtGioiTinh.Visible || txtNgaySinh.Visible)
            {
                string hoten = txtHoTen.Text;
                string diachi = txtDiaChi.Text;
                DateTime ngaysinh = dtpNgaySinh.Value;
                char gioitinh = radioNam.Checked ? 'M' : 'F';
                ThiSinh thisinh = new ThiSinh
                {
                    MaThiSinh = Convert.ToInt32(txtMaSo.Text), // Lấy MaThiSinh từ TextBox
                    HoTenThiSinh = hoten,
                    NgaySinh = ngaysinh,
                    GioiTinh = gioitinh,
                    DiaChi = diachi,
                    Username = this.username //
                };

                bool result = tsBBL.SuaThiSinh(thisinh);

                // Nếu đang hiển thị các điều khiển, ẩn đi và hiển thị các điều khiển khác
                txtGioiTinh.Visible = false;
                txtNgaySinh.Visible = false;
                dtpNgaySinh.Visible = true;
                radioNam.Visible = true;
                radioNu.Visible = true;
                btnSuaThongTin.Text = "LƯU";
            }
            else
            {
                // Nếu không hiển thị các điều khiển trên, ẩn dtpNgaySinh, radioNam, radioNu và hiển thị các điều khiển ban đầu
                txtGioiTinh.Visible = true;
                txtNgaySinh.Visible = true;
                dtpNgaySinh.Visible = false;
                radioNam.Visible = false;
                radioNu.Visible = false;
                btnSuaThongTin.Text = "SỬA THÔNG TIN";
            }
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string result = tkBBL.DoiMatKhau(username, currentPassword, newPassword, confirmPassword);

            MessageBox.Show(result);
        }

        private void btnChiTietKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewKetQua.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn lần thi để xem lại bài làm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy MaThiSinh của thí sinh đã chọn
                int maKetQua = int.Parse(listViewKetQua.SelectedItems[0].SubItems[0].Text);

                // Mở form mới và truyền MaThiSinh
                FormChiTietKetQua frm = new FormChiTietKetQua(maKetQua);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
