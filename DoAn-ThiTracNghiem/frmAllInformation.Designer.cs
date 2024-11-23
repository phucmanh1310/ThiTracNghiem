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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllInformation));
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            label1 = new Label();
            txtSearchResult = new TextBox();
            btnRefreshResult = new Button();
            btnSearchResult = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSearchResult);
            groupBox1.Controls.Add(btnRefreshResult);
            groupBox1.Controls.Add(btnSearchResult);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(20, 615);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1116, 426);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = " KẾT QUẢ THI";
            // 
            // listView1
            // 
            listView1.Location = new Point(16, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(1086, 301);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(245, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 23);
            label1.TabIndex = 7;
            label1.Text = "Tìm kiếm thông tin kết quả :";
            // 
            // txtSearchResult
            // 
            txtSearchResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchResult.Location = new Point(507, 48);
            txtSearchResult.Margin = new Padding(4, 5, 4, 5);
            txtSearchResult.Name = "txtSearchResult";
            txtSearchResult.Size = new Size(341, 29);
            txtSearchResult.TabIndex = 5;
            // 
            // btnRefreshResult
            // 
            btnRefreshResult.BackgroundImage = (Image)resources.GetObject("btnRefreshResult.BackgroundImage");
            btnRefreshResult.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshResult.ForeColor = Color.MediumAquamarine;
            btnRefreshResult.Location = new Point(983, 42);
            btnRefreshResult.Margin = new Padding(4, 5, 4, 5);
            btnRefreshResult.Name = "btnRefreshResult";
            btnRefreshResult.Size = new Size(37, 42);
            btnRefreshResult.TabIndex = 4;
            btnRefreshResult.UseVisualStyleBackColor = true;
            // 
            // btnSearchResult
            // 
            btnSearchResult.BackColor = SystemColors.MenuHighlight;
            btnSearchResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchResult.ForeColor = Color.GhostWhite;
            btnSearchResult.Location = new Point(856, 42);
            btnSearchResult.Margin = new Padding(4, 5, 4, 5);
            btnSearchResult.Name = "btnSearchResult";
            btnSearchResult.Size = new Size(119, 41);
            btnSearchResult.TabIndex = 3;
            btnSearchResult.Text = "Tìm kiếm";
            btnSearchResult.UseVisualStyleBackColor = false;
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
            groupBox2.Location = new Point(16, 19);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1262, 587);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH THÍ SINH";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCapNhat);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1116, 108);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(136, 436);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(21, 156);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 100);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(21, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
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
            btnRefreshInfo.BackgroundImage = (Image)resources.GetObject("btnRefreshInfo.BackgroundImage");
            btnRefreshInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshInfo.ForeColor = Color.MediumAquamarine;
            btnRefreshInfo.Location = new Point(983, 58);
            btnRefreshInfo.Margin = new Padding(4, 5, 4, 5);
            btnRefreshInfo.Name = "btnRefreshInfo";
            btnRefreshInfo.Size = new Size(37, 42);
            btnRefreshInfo.TabIndex = 3;
            btnRefreshInfo.UseVisualStyleBackColor = true;
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
            btnSearchInfo.Size = new Size(119, 41);
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
            ClientSize = new Size(1323, 1055);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAllInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            WindowState = FormWindowState.Maximized;
            Load += frmAllInformation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.Button btnSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.Button btnRefreshResult;
        private System.Windows.Forms.Button btnRefreshInfo;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongTin;
        private ListView listView1;
        private ListView lvInformation;
        public ColumnHeader MaTS;
        public ColumnHeader HoTen;
        public ColumnHeader NgaySinh;
        private ColumnHeader GioiTinh;
        private ColumnHeader DiaChi;
        private ColumnHeader Username;
        private ColumnHeader MatKhau;
        private GroupBox groupBox3;
        private Button btnXoa;
        private Button btnThem;
        private Button btnCapNhat;
    }
}