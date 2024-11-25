using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;
using System.Data.SqlClient;

namespace DoAn_ThiTracNghiem
{
    public partial class frmAllInformation : Form
    {
        public frmAllInformation()
        {
            InitializeComponent();
        }

        private void frmAllInformation_Load(object sender, EventArgs e)
        {
            ShowAllInformation();
        }
        private void ShowAllInformation()
        {
            // Add columns to the ListView code giấy
            //lvInformation.Columns.Add("Mã Thí Sinh", 100);
            //lvInformation.Columns.Add("Họ và Tên", 250);
            //lvInformation.Columns.Add("Ngày Sinh", 200);
            //lvInformation.Columns.Add("Giới Tính", 100);
            //lvInformation.Columns.Add("Địa Chỉ", 200);
            //lvInformation.Columns.Add("Tên Đăng Nhập", 150);
            //lvInformation.Columns.Add("Mật Khẩu", 100);

            // Lấy danh sách thí sinh từ BLL
            ThiSinhBLL thiSinhBLL = new ThiSinhBLL();
            List<ThiSinh> list = thiSinhBLL.GetAllThiSinh();

            if (list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thí sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (var ts in list)
            {
                ListViewItem item = new ListViewItem(ts.MaThiSinh.ToString());
                item.SubItems.Add(ts.HoTenThiSinh);
                item.SubItems.Add(ts.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ts.GioiTinh == 'M' ? "Nam" : "Nữ");
                item.SubItems.Add(ts.DiaChi);
                item.SubItems.Add(ts.Username);
                // Truy xuất mật khẩu cho từng thí sinh
                string password = GetPasswordByUsername(ts.Username);
                // Chuyển mật khẩu thành dạng ẩn
                string hiddenPassword = new string('*', password.Length);
                // Thêm mật khẩu ẩn vào ListView
                item.SubItems.Add(hiddenPassword);


                lvInformation.Items.Add(item);

            }
        }
        //Xem password của thí sinh bằng sự kiện click vào 
        public string GetPasswordByUsername(string username)
        {
            string password = null;
            string query = "SELECT password FROM TaiKhoan WHERE username = @username";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    password = reader["password"].ToString();
                }
            }
            return password;
        }

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInformation.SelectedItems.Count > 0)
            {
                // Lấy username của thí sinh được chọn
                string username = lvInformation.SelectedItems[0].SubItems[5].Text; // Cột chứa username

                // Truy vấn mật khẩu
                string password = GetPasswordByUsername(username);

                // Hiển thị mật khẩu (hoặc xử lý theo yêu cầu)
                MessageBox.Show($"Mật khẩu của tài khoản {username} là: {password}", "Thông tin mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchInfo_Click(object sender, EventArgs e)
        {
            String SinhVienCanTim = txtSearchInfo.Text.Trim();
            if (string.IsNullOrEmpty(SinhVienCanTim))
            {
                MessageBox.Show("Vui lòng nhập họ và tên thí sinh cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThiSinhBLL thiSinhBLL = new ThiSinhBLL();
            try
            {
                List<ThiSinh> dsThiSinh = thiSinhBLL.TraCuuThiSinh(SinhVienCanTim);
                if (dsThiSinh.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thí sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Hiển thị danh sách thí sinh tìm thấy
                lvInformation.Items.Clear();
                foreach (var ts in dsThiSinh)
                {
                    ListViewItem item = new ListViewItem(ts.MaThiSinh.ToString());
                    item.SubItems.Add(ts.HoTenThiSinh);
                    item.SubItems.Add(ts.NgaySinh.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ts.GioiTinh == 'M' ? "Nam" : "Nữ");
                    item.SubItems.Add(ts.DiaChi);
                    item.SubItems.Add(ts.Username);

                    // Lấy mật khẩu ẩn
                    string password = GetPasswordByUsername(ts.Username);
                    string hiddenPassword = new string('*', password.Length);
                    item.SubItems.Add(hiddenPassword);

                    lvInformation.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshInfo_Click(object sender, EventArgs e)
        {
            lvInformation.Items.Clear(); // Chỉ xóa dữ liệu (Items), giữ lại cột
            ShowAllInformation();
            txtSearchInfo.Clear();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String hoTen = txtHoTen.Text;
                String diaChi = txtDiaChi.Text;
                String Username = txtUsername.Text;
                String Password = txtPsssword.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                string gioiTinhText = cbbGioiTinh.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox
                if (gioiTinhText == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                char gioiTinh = gioiTinhText == "Nam" ? 'M' : 'F'; // Chuyển đổi sang ký tự
                TaiKhoan tk = new TaiKhoan
                {
                    Username = Username,
                    Password = Password,
                    IsAdmin = false
                };
                ThiSinh ts = new ThiSinh
                {
                    Username = Username,
                    HoTenThiSinh = hoTen,
                    DiaChi = diaChi,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh
                };
                //thêm thí sinh qua lớp bll
                ThiSinhBLL tsBLL = new ThiSinhBLL();
                if (tsBLL.AddThiSinh(ts, tk))
                {
                    MessageBox.Show($"Tạo tài khoản mới cho thí sinh {hoTen} Thành công");
                    lvInformation.Items.Clear(); // Xóa danh sách hiện tại
                    ShowAllInformation();        // Hiển thị danh sách cập nhật
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String Username = txtUsername.Text;
                TaiKhoanBLL tkBLL = new TaiKhoanBLL();
                bool tontai = tkBLL.CheckUsername(Username);
                if (tontai)
                {
                    MessageBox.Show("Bạn có thể dùng tên đăng nhập này!", "Tên đăng nhập hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!\nMời bạn nhập tên đăng nhập khác!", "Tồn tại tên đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi kiểm tra tên đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
