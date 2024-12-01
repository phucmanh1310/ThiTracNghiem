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
            btnXemDiem.Visible = false;
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
            // Kiểm tra xem có ít nhất một item được chọn trong ListView
            if (lvInformation.SelectedItems.Count > 0)
            {
                // Xóa các item trong ComboBox Giới tính
                cbbGioiTinh.Items.Clear();
                cbbGioiTinh.Items.Add("Nam");
                cbbGioiTinh.Items.Add("Nữ");

                // Lấy thông tin từ dòng được chọn và gán vào các điều khiển trên form
                var selectedItem = lvInformation.SelectedItems[0]; // Lấy item được chọn

                // Cập nhật TextBox cho họ tên
                txtHoTen.Text = selectedItem.SubItems[1].Text;

                // Chuyển đổi ngày sinh từ ListView thành DateTime và gán vào DateTimePicker
                DateTime ngaySinh;
                string ngaySinhString = selectedItem.SubItems[2].Text;  // Lấy giá trị ngày sinh từ ListView
                if (DateTime.TryParseExact(ngaySinhString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    dateTimePicker1.Value = ngaySinh; // Nếu chuyển đổi thành công, gán vào DateTimePicker
                }
                else
                {
                    // Nếu không chuyển đổi được, thông báo lỗi hoặc giữ giá trị mặc định
                    MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cập nhật ComboBox giới tính dựa trên giá trị trong ListView
                string gioiTinh = selectedItem.SubItems[3].Text;
                if (gioiTinh == "Nam")
                {
                    cbbGioiTinh.SelectedItem = "Nam"; // Chọn "Nam" nếu dữ liệu là Nam
                }
                else if (gioiTinh == "Nữ")
                {
                    cbbGioiTinh.SelectedItem = "Nữ"; // Chọn "Nữ" nếu dữ liệu là Nữ
                }
                else
                {
                    cbbGioiTinh.SelectedItem = null; // Nếu không có dữ liệu hợp lệ, đặt ComboBox thành null
                }

                // Cập nhật TextBox cho địa chỉ
                txtDiaChi.Text = selectedItem.SubItems[4].Text;

                // Cập nhật TextBox cho username
                txtUsername.Text = selectedItem.SubItems[5].Text;
                txtPsssword.Text = selectedItem.SubItems[6].Text;
                btnThem.Visible = false;
                txtUsername.ReadOnly = true;
                btnXemDiem.Visible = true;
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
        private void txtHien_Click_1(object sender, EventArgs e)
        {
            if (lvInformation.SelectedItems.Count > 0)
            {
                // Lấy username từ mục được chọn
                string username = lvInformation.SelectedItems[0].SubItems[5].Text;

                // Lấy mật khẩu từ cơ sở dữ liệu
                string password = GetPasswordByUsername(username);

                // Hiển thị mật khẩu
                MessageBox.Show($"Mật khẩu của tài khoản {username} là: {password}",
                                "Hiển Thị Mật Khẩu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thí sinh trong danh sách!",
                                "Thông Báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void btnRefreshInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Xóa tất cả các mục trong ListView
                lvInformation.Items.Clear();

                // 2. Hiển thị lại danh sách thí sinh
                ShowAllInformation();

                // 3. Xóa dữ liệu trong các TextBox và ComboBox
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtUsername.Clear();
                txtPsssword.Clear();

                // Đặt lại ComboBox giới tính về null hoặc giá trị mặc định
                cbbGioiTinh.SelectedItem = null;

                // Đặt lại DateTimePicker về giá trị mặc định (ngày hiện tại)
                dateTimePicker1.Value = DateTime.Now;

                // 4. Đảm bảo các nút hiển thị đúng trạng thái:
                // Hiển thị lại nút "Thêm"
                btnThem.Visible = true;

                // Ẩn nút "Xem Điểm" và các nút không cần thiết khi chưa chọn thí sinh
                btnXemDiem.Visible = false;

                // Đảm bảo không có item nào được chọn trong ListView
                lvInformation.SelectedItems.Clear();

                // 5. Đảm bảo rằng txtUsername có thể nhập lại
                txtUsername.ReadOnly = false; // Đảm bảo rằng txtUsername không phải readonly
                txtUsername.Enabled = true;   // Đảm bảo rằng txtUsername không bị disabled
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int maThiSinh = tsBLL.AddThiSinh(ts, tk);
                if (maThiSinh > 0)
                {
                    MessageBox.Show($"Tạo tài khoản mới cho thí sinh {hoTen} Thành công, mã thí sinh: {maThiSinh}");
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
            try
            {
                if (lvInformation.SelectedItems.Count > 0)
                {
                    int maThiSinh = int.Parse(lvInformation.SelectedItems[0].SubItems[0].Text);

                    // Xóa thí sinh qua BLL
                    ThiSinhBLL tsBLL = new ThiSinhBLL();
                    bool isDeleted = tsBLL.DeleteThiSinh(maThiSinh);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa thí sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Đặt lại trạng thái giao diện
                        ResetFormState();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thí sinh thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thí sinh trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm đặt lại trạng thái giao diện
        // ResetFormState (có thể có trong mã của bạn)
        private void ResetFormState()
        {
            // Chỉ xóa danh sách ListView, không xóa TextBox
            lvInformation.Items.Clear();

            // Hiển thị lại danh sách thí sinh
            ShowAllInformation();

            // Để lại các TextBox, ComboBox, DateTimePicker như cũ
            // Không xóa các trường thông tin
            // Đảm bảo ComboBox không bị reset nếu bạn muốn giữ giá trị đã chọn
            // Đảm bảo các TextBox không bị xóa, và DateTimePicker vẫn giữ ngày đã chọn

            // Đảm bảo nút thêm hiển thị lại
            btnThem.Visible = true;
        }

        //cập nhật thông tin thí sinh
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các điều khiển trong form
                if (lvInformation.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thí sinh cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maThiSinh = int.Parse(lvInformation.SelectedItems[0].SubItems[0].Text);
                String hoTen = txtHoTen.Text;
                String diaChi = txtDiaChi.Text;
                String Username = txtUsername.Text;
                String Password = txtPsssword.Text;
                DateTime ngaySinh = dateTimePicker1.Value;

                string gioiTinhText = cbbGioiTinh.SelectedItem?.ToString();
                if (gioiTinhText == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                char gioiTinh = gioiTinhText == "Nam" ? 'M' : 'F';

                // Kiểm tra tính hợp lệ của dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng tài khoản mới
                TaiKhoan tk = new TaiKhoan
                {
                    Username = Username,
                    Password = Password,
                    IsAdmin = false  // Hoặc gán giá trị cho trường này nếu có
                };

                // Tạo đối tượng thí sinh mới
                ThiSinh ts = new ThiSinh
                {
                    Username = Username,
                    HoTenThiSinh = hoTen,
                    DiaChi = diaChi,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh
                };

                // Gọi phương thức cập nhật của lớp BLL
                ThiSinhBLL tsBLL = new ThiSinhBLL();
                bool result = tsBLL.UpdateThiSinhAndAccount(maThiSinh, hoTen, ngaySinh, gioiTinh, diaChi, Username, Password);

                // Kiểm tra kết quả cập nhật
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFormState();
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
        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvInformation.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một thí sinh để xem kết quả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy MaThiSinh của thí sinh đã chọn
                int maThiSinh = int.Parse(lvInformation.SelectedItems[0].SubItems[0].Text);

                // Mở form mới và truyền MaThiSinh
                frmAdminKetQuaThi frmKetQuaChiTiet = new frmAdminKetQuaThi(maThiSinh);
                frmKetQuaChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void frmAllInformation_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận khi người dùng muốn thoát
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình chứ?",
                                                  "Thoát chương trình?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Exclamation);

            // Nếu người dùng chọn Yes, form sẽ được đóng
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy hành động đóng form nếu chọn No
            }
        }
    }
}
