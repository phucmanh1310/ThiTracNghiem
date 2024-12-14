using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;

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
            // Thiết lập các TextBox chỉ để xem, không thể chỉnh sửa
            txtMaSo.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtGioiTinh.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;

            radioNam.Visible = false;
            radioNu.Visible = false;
            dtpNgaySinh.Visible = false;
            btnLuu.Visible = false;
            btnSuaThongTin.Visible = true;

            // Lấy thông tin thí sinh từ database
            ThiSinh thiSinh = tsBBL.GetThiSinh(username);

            if (thiSinh != null)
            {
                txtMaSo.Text = thiSinh.MaThiSinh.ToString();
                txtHoTen.Text = thiSinh.HoTenThiSinh ?? ""; // Tránh lỗi nếu null
                txtDiaChi.Text = thiSinh.DiaChi ?? "";      // Tránh lỗi nếu null
                txtGioiTinh.Text = thiSinh.GioiTinh == 'M' ? "Nam" : "Nữ";
                txtNgaySinh.Text = thiSinh.NgaySinh.ToString("dd/MM/yyyy");
                dtpNgaySinh.Value = thiSinh.NgaySinh; // Cài đặt ngày sinh
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin thí sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Làm mới ListView
            RefreshListViewKetQua(thiSinh.MaThiSinh);
        }

        private void RefreshListViewKetQua(int maThiSinh)
        {
            listViewKetQua.Items.Clear();
            List<KetQua> listKQ = kqBLL.LayKetQuaChiTiet(maThiSinh);

            foreach (var k in listKQ)
            {
                // Thêm thông tin kết quả vào ListView
                ListViewItem item = new ListViewItem(k.MaKetQua.ToString());
                item.SubItems.Add(k.LanThi.ToString());
                item.SubItems.Add(k.KetQuaThi); // Số câu đúng
                TimeSpan timeSpan = TimeSpan.FromSeconds(k.ThoiGian);
                item.SubItems.Add(timeSpan.ToString(@"mm\:ss")); // Thời gian làm bài
                item.SubItems.Add(k.TrangThai); // Hiển thị trạng thái (Đạt/Không đạt)

                // Đổi màu cho từng dòng dựa trên trạng thái
                if (k.TrangThai == "Đạt")
                {
                    item.ForeColor = Color.Green;
                }
                else
                {
                    item.ForeColor = Color.Red;
                }

                listViewKetQua.Items.Add(item);
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            txtMaSo.ReadOnly = true; // Không cho sửa mã số
            btnLuu.Visible = true;   // Hiển thị nút Lưu để lưu thay đổi
            btnSuaThongTin.Visible = false; // Ẩn nút Sửa

            if (txtGioiTinh.Visible || txtNgaySinh.Visible)
            {
                txtHoTen.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtGioiTinh.Visible = false;
                txtNgaySinh.Visible = false;
                dtpNgaySinh.Visible = true;
                radioNam.Visible = true;
                radioNu.Visible = true;

                if (txtGioiTinh.Text == "Nam")
                {
                    radioNam.Checked = true;
                }
                else if (txtGioiTinh.Text == "Nữ")
                {
                    radioNu.Checked = true;
                }
            }
            else
            {
                txtGioiTinh.Visible = true;
                txtNgaySinh.Visible = true;
                dtpNgaySinh.Visible = false;
                radioNam.Visible = false;
                radioNu.Visible = false;
            }

            Application.DoEvents(); // Đảm bảo giao diện được làm mới ngay lập tức
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int maThiSinh = int.Parse(txtMaSo.Text);
                string hoTen = txtHoTen.Text;
                string diaChi = txtDiaChi.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;

                char gioiTinh = radioNam.Checked ? 'M' : 'F';

                ThiSinh ts = new ThiSinh
                {
                    MaThiSinh = maThiSinh,
                    HoTenThiSinh = hoTen,
                    DiaChi = diaChi,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh
                };

                bool result = tsBBL.SuaThiSinh(ts);

                if (result)
                {
                    MessageBox.Show("Sửa thông tin thí sinh hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnSuaThongTin.Visible = true;
                    btnLuu.Visible = false;

                    txtHoTen.ReadOnly = true;
                    txtDiaChi.ReadOnly = true;
                    txtGioiTinh.ReadOnly = true;
                    txtNgaySinh.ReadOnly = true;

                    txtGioiTinh.Visible = true;
                    txtNgaySinh.Visible = true;
                    dtpNgaySinh.Visible = false;
                    radioNam.Visible = false;
                    radioNu.Visible = false;

                    frmInformationAndHistory_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                int maKetQua = int.Parse(listViewKetQua.SelectedItems[0].SubItems[0].Text);

                FormChiTietKetQua frm = new FormChiTietKetQua(maKetQua);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
