using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace DoAn_ThiTracNghiem
{
    public partial class frmLogin : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình chứ?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp signUp = new frmSignUp();
            signUp.ShowDialog();
            signUp = null;
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy dữ liệu nhập vào
                taikhoan.Username = txtUsername.Text;
                taikhoan.Password = txtPassword.Text;
                //kết quả đăng nhập
                var loginResult = tkBLL.checkLogin(taikhoan);

                if (!loginResult.isValid)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
                }

                // Thông báo đăng nhập thành công
                MessageBox.Show($"Đăng nhập thành công! Xin chào {loginResult.username}");

                // Chuyển hướng form
                if (loginResult.isAdmin)
                {
                    // Chuyển sang frmAdmin
                    frmAdmin adminForm = new frmAdmin();
                    this.Hide();
                    adminForm.ShowDialog();
                }
                else
                {
                    // Chuyển sang frmUser
                    frmUser userForm = new frmUser();
                    this.Hide();
                    userForm.ShowDialog();
                }

                // Hiển thị lại form login nếu cần
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}