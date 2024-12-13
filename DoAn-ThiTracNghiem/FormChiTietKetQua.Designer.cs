namespace DoAn_ThiTracNghiem
{
    partial class FormChiTietKetQua
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
            pnlDapAn = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnNext = new Button();
            btnPrevious = new Button();
            pictureBoxCauHoi = new PictureBox();
            lbCauHoi = new Label();
            btnQuayLai = new Button();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            pnlDapAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCauHoi).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnlDapAn);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(pictureBoxCauHoi);
            groupBox2.Controls.Add(lbCauHoi);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.RoyalBlue;
            groupBox2.Location = new Point(26, 1);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(886, 543);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CÂU HỎI";
            // 
            // pnlDapAn
            // 
            pnlDapAn.Controls.Add(radioButton1);
            pnlDapAn.Controls.Add(radioButton2);
            pnlDapAn.Controls.Add(radioButton3);
            pnlDapAn.Controls.Add(radioButton4);
            pnlDapAn.FlowDirection = FlowDirection.TopDown;
            pnlDapAn.Location = new Point(36, 152);
            pnlDapAn.Name = "pnlDapAn";
            pnlDapAn.Size = new Size(457, 231);
            pnlDapAn.TabIndex = 14;
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ControlText;
            radioButton1.Location = new Point(3, 3);
            radioButton1.MaximumSize = new Size(0, 280);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(443, 30);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ControlText;
            radioButton2.Location = new Point(3, 39);
            radioButton2.MaximumSize = new Size(0, 280);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(443, 33);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.ControlText;
            radioButton3.Location = new Point(3, 78);
            radioButton3.MaximumSize = new Size(0, 280);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(443, 32);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.ControlText;
            radioButton4.Location = new Point(3, 116);
            radioButton4.MaximumSize = new Size(0, 280);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(443, 33);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(743, 483);
            btnNext.Margin = new Padding(2);
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
            btnPrevious.Location = new Point(36, 484);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(102, 38);
            btnPrevious.TabIndex = 11;
            btnPrevious.Text = "Câu trước";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pictureBoxCauHoi
            // 
            pictureBoxCauHoi.Location = new Point(500, 152);
            pictureBoxCauHoi.Margin = new Padding(4);
            pictureBoxCauHoi.Name = "pictureBoxCauHoi";
            pictureBoxCauHoi.Size = new Size(353, 231);
            pictureBoxCauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCauHoi.TabIndex = 5;
            pictureBoxCauHoi.TabStop = false;
            // 
            // lbCauHoi
            // 
            lbCauHoi.AutoSize = true;
            lbCauHoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCauHoi.ForeColor = Color.Black;
            lbCauHoi.Location = new Point(36, 58);
            lbCauHoi.Margin = new Padding(4, 0, 4, 0);
            lbCauHoi.Name = "lbCauHoi";
            lbCauHoi.Size = new Size(90, 28);
            lbCauHoi.TabIndex = 0;
            lbCauHoi.Text = "Câu hỏi?";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(996, 503);
            btnQuayLai.Margin = new Padding(2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(138, 41);
            btnQuayLai.TabIndex = 10;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // groupBox3
            // 
            groupBox3.ForeColor = Color.CornflowerBlue;
            groupBox3.Location = new Point(919, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(254, 357);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "ĐÁP ÁN";
            // 
            // FormChiTietKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 586);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnQuayLai);
            Margin = new Padding(4);
            Name = "FormChiTietKetQua";
            Text = "frmExamination";
            Load += FormChiTietKetQua_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlDapAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCauHoi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label lbCauHoi;
        private PictureBox pictureBoxCauHoi;
        private Button btnQuayLai;
        private Button btnNext;
        private Button btnPrevious;
        private GroupBox groupBox3;
        private Button button1;
        private Button button6;
        private Button button7;
        private Button button2;
        private Button button4;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private FlowLayoutPanel pnlDapAn;
    }
}