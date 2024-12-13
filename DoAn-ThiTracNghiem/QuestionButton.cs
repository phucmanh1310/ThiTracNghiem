using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn_ThiTracNghiem
{
    public partial class QuestionButton : UserControl
    {
        private Button btnQuestion;

        public Button Button => btnQuestion;

        public int QuestionIndex { get; set; }
        public bool IsSelected { get; private set; } = false;

        public event EventHandler ButtonClicked;

        public QuestionButton()
        {
            InitializeComponent();
            btnQuestion = new Button
            {
                Size = new Size(50, 50),
                BackColor = Color.White
            };
            btnQuestion.Click += (s, e) => OnButtonClicked();
            Controls.Add(btnQuestion);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // QuestionButton
            // 
            Name = "QuestionButton";
            Size = new Size(71, 43);
            ResumeLayout(false);
        }

        private void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetSelected(bool isSelected)
        {
            Button.BackColor = isSelected ? Color.Green : Color.White;
        }


        public void SetText(string text)
        {
            btnQuestion.Text = text;
        }
    }
}

