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
            ((System.ComponentModel.ISupportInitialize)picThemCauHoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThongTinThiSinh).BeginInit();
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
            picThemCauHoi.Location = new Point(87, 112);
            picThemCauHoi.Margin = new Padding(2);
            picThemCauHoi.Name = "picThemCauHoi";
            picThemCauHoi.Size = new Size(347, 321);
            picThemCauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picThemCauHoi.TabIndex = 1;
            picThemCauHoi.TabStop = false;
            picThemCauHoi.Click += picThemCauHoi_Click;
            // 
            // picThongTinThiSinh
            // 
            picThongTinThiSinh.Image = Properties.Resources.history;
            picThongTinThiSinh.Location = new Point(473, 112);
            picThongTinThiSinh.Margin = new Padding(2);
            picThongTinThiSinh.Name = "picThongTinThiSinh";
            picThongTinThiSinh.Size = new Size(347, 321);
            picThongTinThiSinh.SizeMode = PictureBoxSizeMode.StretchImage;
            picThongTinThiSinh.TabIndex = 2;
            picThongTinThiSinh.TabStop = false;
            picThongTinThiSinh.Click += picThongTinThiSinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(182, 443);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 3;
            label2.Text = "THÊM CÂU HỎI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(473, 443);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(371, 32);
            label3.TabIndex = 4;
            label3.Text = "QUẢN LÝ THÔNG TIN THÍ SINH\r\n";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 506);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picThongTinThiSinh);
            Controls.Add(picThemCauHoi);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAdmin";
            Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)picThemCauHoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThongTinThiSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picThemCauHoi;
        private PictureBox picThongTinThiSinh;
        private Label label2;
        private Label label3;
    }
}