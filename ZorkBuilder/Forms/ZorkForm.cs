using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Zork.World;
using ZorkBuilder.Forms;
using ZorkBuilder.ViewModel;

namespace ZorkBuilder
{
    public partial class ZorkForm : Form
    {
        private WorldViewModel viewModel;

        private WorldViewModel ViewModel
        {
            get => viewModel;

            set
            {
                if(viewModel != value)
                {
                    viewModel = value;
                    worldViewModelBindingSource.DataSource = viewModel;
                }
            }
        }

        private bool WorldIsLoaded
        {
            get
            {
                return viewModel.WorldIsLoaded;
            }
            set
            {
                viewModel.WorldIsLoaded = value;

                AddRoomButton.Enabled = viewModel.WorldIsLoaded;

                DeleteRoomButton.Enabled = viewModel.WorldIsLoaded;

                SaveFileButton.Enabled = viewModel.WorldIsLoaded;

                SetWelcomeMessage.Enabled = viewModel.WorldIsLoaded;
            }
        }

        public ZorkForm()
        {
            InitializeComponent();

            ViewModel = new WorldViewModel();

            WorldIsLoaded = false;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            { 
                try
                {
                    string jsonString = File.ReadAllText(OpenFileDialog.FileName);

                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);

                    WorldIsLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
               if( addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Rooms rooms = new Rooms(addRoomForm.RoomName);
                    viewModel.Rooms.Add(rooms);
                }
            }
        }

        private void SetWelcomeMessage_Click(object sender, EventArgs e)
        {
            using (SetWelcomeForm setWelcomeForm = new SetWelcomeForm())
            {
                if(setWelcomeForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
