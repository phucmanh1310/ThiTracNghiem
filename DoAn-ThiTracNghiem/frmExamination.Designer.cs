namespace DoAn_ThiTracNghiem
{
    partial class frmExamination
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtMaSo = new TextBox();
            txtHoTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lableTime = new Label();
            groupBox2 = new GroupBox();
            btnNext = new Button();
            btnPrevious = new Button();
            btnSubmit = new Button();
            pictureBoxCauHoi = new PictureBox();
            lbCauHoi = new Label();
            pnlDapAn = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCauHoi).BeginInit();
            pnlDapAn.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(26, 13);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(383, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN";
            // 
            // txtMaSo
            // 
            txtMaSo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaSo.Location = new Point(96, 51);
            txtMaSo.Margin = new Padding(5, 4, 5, 4);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(222, 27);
            txtMaSo.TabIndex = 3;
            txtMaSo.Text = "Mã số";
            txtMaSo.TextAlign = HorizontalAlignment.Center;
            txtMaSo.UseWaitCursor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(96, 99);
            txtHoTen.Margin = new Padding(5, 4, 5, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(222, 27);
            txtHoTen.TabIndex = 2;
            txtHoTen.Text = "Họ tên";
            txtHoTen.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 101);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // lableTime
            // 
            lableTime.AutoSize = true;
            lableTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableTime.ForeColor = Color.Red;
            lableTime.Location = new Point(142, 53);
            lableTime.Margin = new Padding(5, 0, 5, 0);
            lableTime.Name = "lableTime";
            lableTime.Size = new Size(109, 46);
            lableTime.TabIndex = 4;
            lableTime.Text = "15:00";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnSubmit);
            groupBox2.Controls.Add(pictureBoxCauHoi);
            groupBox2.Controls.Add(lbCauHoi);
            groupBox2.Controls.Add(pnlDapAn);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.RoyalBlue;
            groupBox2.Location = new Point(26, 175);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(886, 543);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CÂU HỎI";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(743, 483);
            btnNext.Margin = new Padding(2, 3, 2, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(110, 35);
            btnNext.TabIndex = 12;
            btnNext.Text = "Câu sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(37, 484);
            btnPrevious.Margin = new Padding(2, 3, 2, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(102, 37);
            btnPrevious.TabIndex = 11;
            btnPrevious.Text = "Câu trước";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(347, 477);
            btnSubmit.Margin = new Padding(2, 3, 2, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(177, 41);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "NỘP BÀI";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pictureBoxCauHoi
            // 
            pictureBoxCauHoi.Location = new Point(523, 152);
            pictureBoxCauHoi.Margin = new Padding(5, 4, 5, 4);
            pictureBoxCauHoi.Name = "pictureBoxCauHoi";
            pictureBoxCauHoi.Size = new Size(353, 295);
            pictureBoxCauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCauHoi.TabIndex = 5;
            pictureBoxCauHoi.TabStop = false;
            // 
            // lbCauHoi
            // 
            lbCauHoi.AutoSize = true;
            lbCauHoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCauHoi.ForeColor = Color.Black;
            lbCauHoi.Location = new Point(37, 59);
            lbCauHoi.Margin = new Padding(5, 0, 5, 0);
            lbCauHoi.Name = "lbCauHoi";
            lbCauHoi.Size = new Size(90, 28);
            lbCauHoi.TabIndex = 0;
            lbCauHoi.Text = "Câu hỏi?";
            // 
            // pnlDapAn
            // 
            pnlDapAn.Controls.Add(radioButton1);
            pnlDapAn.Controls.Add(radioButton2);
            pnlDapAn.Controls.Add(radioButton3);
            pnlDapAn.Controls.Add(radioButton4);
            pnlDapAn.FlowDirection = FlowDirection.TopDown;
            pnlDapAn.Location = new Point(18, 152);
            pnlDapAn.Name = "pnlDapAn";
            pnlDapAn.Size = new Size(487, 295);
            pnlDapAn.TabIndex = 14;
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ControlText;
            radioButton1.Location = new Point(3, 3);
            radioButton1.MaximumSize = new Size(0, 280);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(469, 63);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ControlText;
            radioButton2.Location = new Point(3, 72);
            radioButton2.MaximumSize = new Size(0, 280);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(469, 63);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.ControlText;
            radioButton3.Location = new Point(3, 141);
            radioButton3.MaximumSize = new Size(0, 280);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(469, 61);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.ControlText;
            radioButton4.Location = new Point(3, 208);
            radioButton4.MaximumSize = new Size(0, 280);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(469, 63);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox3
            // 
            groupBox3.ForeColor = Color.CornflowerBlue;
            groupBox3.Location = new Point(919, 183);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(261, 451);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "ĐÁP ÁN";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lableTime);
            groupBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.RoyalBlue;
            groupBox4.Location = new Point(435, 13);
            groupBox4.Margin = new Padding(5, 4, 5, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 4, 5, 4);
            groupBox4.Size = new Size(383, 155);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "THỜI GIAN THI CÒN LẠI";
            // 
            // frmExamination
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 821);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmExamination";
            Text = "frmExamination";
            FormClosing += frmExamination_FormClosing;
            Load += frmExamination_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCauHoi).EndInit();
            pnlDapAn.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtMaSo;
        private TextBox txtHoTen;
        private Label label2;
        private Label label1;
        private Label lableTime;
        private Label lbCauHoi;
        private PictureBox pictureBoxCauHoi;
        private Button btnSubmit;
        private Button btnNext;
        private Button btnPrevious;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private FlowLayoutPanel pnlDapAn;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}