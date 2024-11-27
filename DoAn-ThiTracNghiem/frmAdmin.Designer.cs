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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            label1 = new Label();
            picThemCauHoi = new PictureBox();
            picThongTinThiSinh = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picThemCauHoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThongTinThiSinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(229, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(485, 54);
            label1.TabIndex = 0;
            label1.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // picThemCauHoi
            // 
            picThemCauHoi.Image = Properties.Resources.question_answer;
            picThemCauHoi.Location = new Point(20, 112);
            picThemCauHoi.Margin = new Padding(2);
            picThemCauHoi.Name = "picThemCauHoi";
            picThemCauHoi.Size = new Size(233, 218);
            picThemCauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picThemCauHoi.TabIndex = 1;
            picThemCauHoi.TabStop = false;
            picThemCauHoi.Click += picThemCauHoi_Click;
            // 
            // picThongTinThiSinh
            // 
            picThongTinThiSinh.Image = Properties.Resources.history;
            picThongTinThiSinh.Location = new Point(325, 112);
            picThongTinThiSinh.Margin = new Padding(2);
            picThongTinThiSinh.Name = "picThongTinThiSinh";
            picThongTinThiSinh.Size = new Size(241, 218);
            picThongTinThiSinh.SizeMode = PictureBoxSizeMode.StretchImage;
            picThongTinThiSinh.TabIndex = 2;
            picThongTinThiSinh.TabStop = false;
            picThongTinThiSinh.Click += picThongTinThiSinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(69, 345);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 3;
            label2.Text = "THÊM CÂU HỎI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(301, 345);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(309, 28);
            label3.TabIndex = 4;
            label3.Text = "QUẢN LÝ THÔNG TIN THÍ SINH\r\n";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(649, 345);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 28);
            label4.TabIndex = 6;
            label4.Text = "QUẢN LÝ KẾT QUẢ THI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(636, 112);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 506);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picThongTinThiSinh);
            Controls.Add(picThemCauHoi);
            Controls.Add(label1);
            Controls.Add(label4);
            Margin = new Padding(2);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)picThemCauHoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThongTinThiSinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picThemCauHoi;
        private PictureBox picThongTinThiSinh;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}