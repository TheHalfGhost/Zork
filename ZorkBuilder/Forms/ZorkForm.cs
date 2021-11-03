using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Zork.World;
using ZorkBuilder.Controls;
using ZorkBuilder.Forms;
using ZorkBuilder.ViewModel;

namespace ZorkBuilder
{
    public partial class ZorkForm : Form
    {
        private WorldViewModel viewModel;

        private Dictionary<NeighborLocations, NeighborsControl> neighborsControlsMap;

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

            neighborsControlsMap = new Dictionary<NeighborLocations, NeighborsControl>
            {
                {NeighborLocations.NORTH, NorthControl},
                {NeighborLocations.SOUTH, SouthContorl},
                {NeighborLocations.WEST, WestControl},
                {NeighborLocations.EAST, EastControl}

            };
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

                    Rooms selectedRoom = ListRooms.SelectedItem as Rooms;

                    foreach (var control in neighborsControlsMap.Values)
                    {
                        control.Rooms = selectedRoom;
                    }
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

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            string filename = "TestFile.json";
            viewModel.SaveWorld(filename);
        }

        private void ListRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var control in neighborsControlsMap.Values)
            {
                Rooms selectedRoom = ListRooms.SelectedItem as Rooms;

                control.Rooms = selectedRoom;
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (ListRooms.Items.Count >= 1)
            {
                if (ListRooms.SelectedValue != null)
                {
                    ListRooms.Items.Remove(ListRooms.SelectedItem);
                }
            }
        }

        private void StartingLocationComboBox_BindingContextChanged(object sender, EventArgs e)
        {
            StartingLocationComboBox.DataSource = new BindingSource { DataSource = ListRooms.DataSource };

        }
    }
}
