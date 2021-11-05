using System;
using System.Windows.Forms;

namespace ZorkBuilder.Forms
{
    public partial class WelcomeForm : Form
    {
        public string NewMessage
        {
            get
            {
                return NewMessageText.Text;
            }
        }

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SetButton.Enabled = !string.IsNullOrEmpty(NewMessage);
        }
    }
}
