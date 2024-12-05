namespace DoAn_ThiTracNghiem
{
    partial class frmAllInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnXemDiem = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbbGioiTinh = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtPsssword = new TextBox();
            txtUsername = new TextBox();
            txtHoTen = new TextBox();
            btnCapNhat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            lvInformation = new ListView();
            MaTS = new ColumnHeader();
            HoTen = new ColumnHeader();
            NgaySinh = new ColumnHeader();
            GioiTinh = new ColumnHeader();
            DiaChi = new ColumnHeader();
            Username = new ColumnHeader();
            MatKhau = new ColumnHeader();
            lblThongTin = new Label();
            btnRefreshInfo = new Button();
            btnSearchInfo = new Button();
            txtSearchInfo = new TextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AccessibleRole = AccessibleRole.None;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(lvInformation);
            groupBox2.Controls.Add(lblThongTin);
            groupBox2.Controls.Add(btnRefreshInfo);
            groupBox2.Controls.Add(btnSearchInfo);
            groupBox2.Controls.Add(txtSearchInfo);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(9, 14);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1120, 928);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH THÍ SINH";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXemDiem);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cbbGioiTinh);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(txtPsssword);
            groupBox3.Controls.Add(txtUsername);
            groupBox3.Controls.Add(txtHoTen);
            groupBox3.Controls.Add(btnCapNhat);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(4, 548);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1102, 337);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hành động";
            // 
            // btnXemDiem
            // 
            btnXemDiem.Location = new Point(386, 262);
            btnXemDiem.Name = "btnXemDiem";
            btnXemDiem.Size = new Size(397, 65);
            btnXemDiem.TabIndex = 18;
            btnXemDiem.Text = "XEM KẾT QUẢ THI CỦA THÍ SINH NÀY";
            btnXemDiem.UseVisualStyleBackColor = true;
            btnXemDiem.Click += btnXemDiem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1017, 74);
            button1.Name = "button1";
            button1.Size = new Size(65, 29);
            button1.TabIndex = 17;
            button1.Text = "Kiểm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(734, 145);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 16;
            label7.Text = "Mật khẩu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(704, 81);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 15;
            label6.Text = "Tên tài khoản :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(433, 26);
            label5.Name = "label5";
            label5.Size = new Size(350, 38);
            label5.TabIndex = 14;
            label5.Text = "Thông tin thí sinh chi tiết";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 178);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 13;
            label4.Text = "Giới tính :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 129);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 12;
            label3.Text = "Ngày sinh :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 227);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 11;
            label2.Text = "Địa chỉ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 81);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 10;
            label1.Text = "Họ và tên :";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(326, 170);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(124, 31);
            cbbGioiTinh.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(326, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 30);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(324, 220);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(282, 30);
            txtDiaChi.TabIndex = 7;
            // 
            // txtPsssword
            // 
            txtPsssword.Location = new Point(852, 138);
            txtPsssword.Name = "txtPsssword";
            txtPsssword.Size = new Size(230, 30);
            txtPsssword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(852, 74);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(159, 30);
            txtUsername.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(324, 74);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(282, 30);
            txtHoTen.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(52, 130);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 50);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(52, 63);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 50);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(52, 199);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 51);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lvInformation
            // 
            lvInformation.Columns.AddRange(new ColumnHeader[] { MaTS, HoTen, NgaySinh, GioiTinh, DiaChi, Username, MatKhau });
            lvInformation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvInformation.Location = new Point(4, 108);
            lvInformation.Name = "lvInformation";
            lvInformation.Size = new Size(1102, 434);
            lvInformation.TabIndex = 8;
            lvInformation.UseCompatibleStateImageBehavior = false;
            lvInformation.View = View.Details;
            lvInformation.SelectedIndexChanged += lvInformation_SelectedIndexChanged;
            // 
            // MaTS
            // 
            MaTS.Text = "MaThiSinh";
            MaTS.Width = 100;
            // 
            // HoTen
            // 
            HoTen.Text = "Họ và tên ";
            HoTen.TextAlign = HorizontalAlignment.Center;
            HoTen.Width = 250;
            // 
            // NgaySinh
            // 
            NgaySinh.Text = "Ngày Sinh";
            NgaySinh.TextAlign = HorizontalAlignment.Center;
            NgaySinh.Width = 200;
            // 
            // GioiTinh
            // 
            GioiTinh.Text = "Giới Tính";
            GioiTinh.TextAlign = HorizontalAlignment.Center;
            GioiTinh.Width = 100;
            // 
            // DiaChi
            // 
            DiaChi.Text = "Địa chỉ";
            DiaChi.TextAlign = HorizontalAlignment.Center;
            DiaChi.Width = 200;
            // 
            // Username
            // 
            Username.Text = "Tên đăng nhập";
            Username.Width = 150;
            // 
            // MatKhau
            // 
            MatKhau.Text = "Mật Khẩu";
            MatKhau.Width = 100;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTin.ForeColor = Color.RoyalBlue;
            lblThongTin.Location = new Point(165, 65);
            lblThongTin.Margin = new Padding(4, 0, 4, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(327, 23);
            lblThongTin.TabIndex = 6;
            lblThongTin.Text = "Tìm kiếm thí sinh thông qua họ và tên :";
            // 
            // btnRefreshInfo
            // 
            btnRefreshInfo.BackColor = SystemColors.ControlLightLight;
            btnRefreshInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshInfo.ForeColor = Color.MediumAquamarine;
            btnRefreshInfo.Image = Properties.Resources.icon_refresh;
            btnRefreshInfo.Location = new Point(985, 58);
            btnRefreshInfo.Margin = new Padding(4, 5, 4, 5);
            btnRefreshInfo.Name = "btnRefreshInfo";
            btnRefreshInfo.Size = new Size(45, 42);
            btnRefreshInfo.TabIndex = 3;
            btnRefreshInfo.UseVisualStyleBackColor = false;
            btnRefreshInfo.Click += btnRefreshInfo_Click;
            // 
            // btnSearchInfo
            // 
            btnSearchInfo.BackColor = SystemColors.MenuHighlight;
            btnSearchInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchInfo.ForeColor = Color.GhostWhite;
            btnSearchInfo.Location = new Point(856, 58);
            btnSearchInfo.Margin = new Padding(4, 5, 4, 5);
            btnSearchInfo.Name = "btnSearchInfo";
            btnSearchInfo.Size = new Size(105, 41);
            btnSearchInfo.TabIndex = 2;
            btnSearchInfo.Text = "Tìm kiếm";
            btnSearchInfo.UseVisualStyleBackColor = false;
            btnSearchInfo.Click += btnSearchInfo_Click;
            // 
            // txtSearchInfo
            // 
            txtSearchInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchInfo.Location = new Point(507, 62);
            txtSearchInfo.Margin = new Padding(4, 5, 4, 5);
            txtSearchInfo.Name = "txtSearchInfo";
            txtSearchInfo.Size = new Size(341, 29);
            txtSearchInfo.TabIndex = 1;
            // 
            // frmAllInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 901);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAllInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            FormClosed += frmAllInformation_FormClosed;
            Load += frmAllInformation_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.Button btnRefreshInfo;
        private System.Windows.Forms.Label lblThongTin;
        private ListView lvInformation;
        public ColumnHeader MaTS;
        public ColumnHeader HoTen;
        public ColumnHeader NgaySinh;
        private ColumnHeader GioiTinh;
        private ColumnHeader DiaChi;
        private GroupBox groupBox3;
        private Button btnXoa;
        private Button btnThem;
        private Button btnCapNhat;
        private TextBox txtDiaChi;
        private TextBox txtPsssword;
        private TextBox txtUsername;
        private TextBox txtHoTen;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbbGioiTinh;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label7;
        private Label label6;
        private ColumnHeader Username;
        private ColumnHeader MatKhau;
        private Button button1;
        private Button btnXemDiem;
    }
}