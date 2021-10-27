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
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get
            {
                return NametextBox.Text;
            }
        }
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            AddRoomButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
