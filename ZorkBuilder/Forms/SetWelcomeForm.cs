using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorkBuilder.Forms
{
    public partial class SetWelcomeForm : Form
    {
        public string SetLocation
        {
            get
            {
                return WelcomeText.Text;
            }
        }
        public SetWelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeText_TextChanged(object sender, EventArgs e)
        {
            SetButton.Enabled = !string.IsNullOrEmpty(SetLocation);
        }
    }
}
