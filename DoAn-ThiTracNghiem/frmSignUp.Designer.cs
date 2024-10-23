namespace DoAn_ThiTracNghiem
{
    partial class frmSignUp
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
            lblTitle = new Label();
            lblName = new Label();
            lblPassWord = new Label();
            lblPassword1 = new Label();
            lblFullName = new Label();
            lblSex = new Label();
            lblBornDate = new Label();
            lblAddress = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPasswordAgain = new TextBox();
            txtFullName = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnCheck = new Button();
            textBox1 = new TextBox();
            btnBack = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(184, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(49, 137);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Tên đăng nhập";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(49, 223);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(86, 23);
            lblPassWord.TabIndex = 2;
            lblPassWord.Text = "Mật khẩu";
            // 
            // lblPassword1
            // 
            lblPassword1.AutoSize = true;
            lblPassword1.Location = new Point(49, 316);
            lblPassword1.Name = "lblPassword1";
            lblPassword1.Size = new Size(158, 23);
            lblPassword1.TabIndex = 3;
            lblPassword1.Text = "Nhập lại mật khẩu";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(401, 137);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(151, 23);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Họ và tên thí sinh";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(401, 223);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(80, 23);
            lblSex.TabIndex = 5;
            lblSex.Text = "Giới tính";
            // 
            // lblBornDate
            // 
            lblBornDate.AutoSize = true;
            lblBornDate.Location = new Point(508, 223);
            lblBornDate.Name = "lblBornDate";
            lblBornDate.Size = new Size(215, 46);
            lblBornDate.TabIndex = 6;
            lblBornDate.Text = "Ngày Sinh (dd/mm/yyyy)\r\n\r\n";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(401, 316);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 23);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.GrayText;
            txtUsername.Location = new Point(52, 176);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 30);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.GrayText;
            txtPassword.Location = new Point(52, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 30);
            txtPassword.TabIndex = 9;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.ForeColor = SystemColors.GrayText;
            txtPasswordAgain.Location = new Point(52, 355);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.Size = new Size(287, 30);
            txtPasswordAgain.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.ForeColor = SystemColors.GrayText;
            txtFullName.Location = new Point(401, 176);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(299, 30);
            txtFullName.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(401, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(65, 31);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(510, 269);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(45, 31);
            comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(584, 269);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(45, 31);
            comboBox3.TabIndex = 14;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(655, 269);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(45, 31);
            comboBox4.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(561, 274);
            label1.Name = "label1";
            label1.Size = new Size(17, 27);
            label1.TabIndex = 16;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(635, 274);
            label2.Name = "label2";
            label2.Size = new Size(17, 27);
            label2.TabIndex = 17;
            label2.Text = "/";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ActiveCaption;
            btnCheck.ForeColor = SystemColors.ButtonHighlight;
            btnCheck.Location = new Point(279, 176);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(60, 30);
            btnCheck.TabIndex = 18;
            btnCheck.Text = "Kiểm ";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(401, 355);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 30);
            textBox1.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightBlue;
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(52, 457);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 30);
            btnBack.TabIndex = 20;
            btnBack.Text = "Trở về";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(245, 409);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(279, 43);
            btnSignUp.TabIndex = 21;
            btnSignUp.Text = "ĐĂNG KÝ";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 518);
            Controls.Add(btnSignUp);
            Controls.Add(btnBack);
            Controls.Add(textBox1);
            Controls.Add(btnCheck);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtFullName);
            Controls.Add(txtPasswordAgain);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblAddress);
            Controls.Add(lblBornDate);
            Controls.Add(lblSex);
            Controls.Add(lblFullName);
            Controls.Add(lblPassword1);
            Controls.Add(lblPassWord);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblPassWord;
        private Label lblPassword1;
        private Label lblFullName;
        private Label lblSex;
        private Label lblBornDate;
        private Label lblAddress;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPasswordAgain;
        private TextBox txtFullName;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label1;
        private Label label2;
        private Button btnCheck;
        private TextBox textBox1;
        private Button btnBack;
        private Button btnSignUp;
    }
}