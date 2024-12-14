namespace DoAn_ThiTracNghiem
{
    partial class frmAdmin
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
            label1 = new Label();
            picThemCauHoi = new PictureBox();
            picThongTinThiSinh = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnDangXuat = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picThemCauHoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThongTinThiSinh).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 45);
            label1.TabIndex = 0;
            label1.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // picThemCauHoi
            // 
            picThemCauHoi.Image = Properties.Resources.question_answer;
            picThemCauHoi.Location = new Point(38, 24);
            picThemCauHoi.Margin = new Padding(2);
            picThemCauHoi.Name = "picThemCauHoi";
            picThemCauHoi.Size = new Size(324, 224);
            picThemCauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picThemCauHoi.TabIndex = 1;
            picThemCauHoi.TabStop = false;
            picThemCauHoi.Click += picThemCauHoi_Click;
            // 
            // picThongTinThiSinh
            // 
            picThongTinThiSinh.Image = Properties.Resources.history;
            picThongTinThiSinh.Location = new Point(410, 24);
            picThongTinThiSinh.Margin = new Padding(2);
            picThongTinThiSinh.Name = "picThongTinThiSinh";
            picThongTinThiSinh.Size = new Size(312, 224);
            picThongTinThiSinh.SizeMode = PictureBoxSizeMode.StretchImage;
            picThongTinThiSinh.TabIndex = 2;
            picThongTinThiSinh.TabStop = false;
            picThongTinThiSinh.Click += picThongTinThiSinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(125, 256);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "THÊM CÂU HỎI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(414, 256);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(294, 25);
            label3.TabIndex = 4;
            label3.Text = "QUẢN LÝ THÔNG TIN THÍ SINH\r\n";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(312, 282);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(131, 31);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnDangXuat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picThongTinThiSinh);
            groupBox1.Controls.Add(picThemCauHoi);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(24, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 313);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "QUYỀN ADMIN";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 400);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)picThemCauHoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThongTinThiSinh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picThemCauHoi;
        private PictureBox picThongTinThiSinh;
        private Label label2;
        private Label label3;
        private Button btnDangXuat;
        private GroupBox groupBox1;
    }
}