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
    public partial class frmSignUp : Form
    {
        private ThiSinhBLL thiSinhBLL = new ThiSinhBLL();
        public frmSignUp()
        {
            InitializeComponent();
        }
        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát đăng ký chứ?", "Thoát đăng ký?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                this.Dispose();
            }
            else
            {
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string hoTen = txtFullName.Text;
                string matKhau = txtPassword.Text;
                string nhapLaiMatKhau = txtPasswordAgain.Text;
                // Kiểm tra mật khẩu khớp
                if (matKhau != nhapLaiMatKhau)
                {
                    MessageBox.Show("Mật khẩu và Nhập lại mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime ngaySinh = dtpNgaySinh.Value;
                string gioiTinhText = cbxGioiTinh.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox
                if (gioiTinhText == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                char gioiTinh = gioiTinhText == "Nam" ? 'M' : 'F'; // Chuyển đổi sang ký tự
                string diaChi = txtAddress.Text;
                string username = txtUsername.Text;

                TaiKhoan taiKhoan = new TaiKhoan
                {
                    Username = username,
                    Password = matKhau,
                    IsAdmin = false // Mặc định không phải admin
                };
                ThiSinh newThiSinh = new ThiSinh
                {
                    HoTenThiSinh = hoTen,
                    NgaySinh = ngaySinh, // Không cần format vì trường NgaySinh trong DTO là DateTime
                    GioiTinh = gioiTinh,
                    DiaChi = diaChi,
                    Username = username
                };


                // Thêm thí sinh qua lớp BLL
                ThiSinhBLL bll = new ThiSinhBLL();
                if (bll.AddThiSinh(newThiSinh, taiKhoan))
                {
                    MessageBox.Show("Đăng ký thành công! Tiến hành đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form hiện tại
                    this.Close();

                    // Hiển thị lại form đăng nhập
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            cbxGioiTinh.Items.Clear(); // Xóa danh sách cũ nếu có
            cbxGioiTinh.Items.Add("Nam");
            cbxGioiTinh.Items.Add("Nữ");

            cbxGioiTinh.SelectedIndex = 0; // Chọn mặc định là "Nam"
        }

    }
}
