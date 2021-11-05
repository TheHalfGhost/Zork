using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Zork;
using ZorkBuilder.Controls;
using ZorkBuilder.Forms;
using ZorkBuilder.ViewModel;

namespace ZorkBuilder
{
    public partial class MainForm : Form
    {


        private GameViewModel viewModel;

        private Dictionary<Directions, NeighborsUserControl> neighborsControlsMap;

        public string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private GameViewModel ViewModel
        {
            get => viewModel;

            set
            {
                if (viewModel != value)
                {
                    viewModel = value;
                    gameViewModelBindingSource.DataSource = viewModel;
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

                SetWelcomeMessageTool.Enabled = viewModel.WorldIsLoaded;

                StartingLocationComboBox.Enabled = viewModel.WorldIsLoaded;

                DeleteRoomButton.Enabled = viewModel.WorldIsLoaded;

                SaveFileToolStripMenu.Enabled = viewModel.WorldIsLoaded;

                RoomNameText.Enabled = viewModel.WorldIsLoaded;

                DescriptionText.Enabled = viewModel.WorldIsLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            ViewModel = new GameViewModel();

            WorldIsLoaded = false;

            neighborsControlsMap = new Dictionary<Directions, NeighborsUserControl>
            {
                {Directions.NORTH, NorthUserControl},
                {Directions.SOUTH, SouthUserControl},
                {Directions.WEST, WestUserControl},
                {Directions.EAST, EastUserControl}

            };
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room rooms = new Room(addRoomForm.RoomName);
                    viewModel.Rooms.Add(rooms);
                }
            }
        }

        private void DeleteRoom_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Delete This Room?", AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                viewModel.Rooms.Remove((Room)RoomsList.SelectedItem);
                RoomsList.SelectedItem = viewModel.Rooms.FirstOrDefault();
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(OpenFileDialog.FileName);

                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);

                    WorldIsLoaded = true;

                    Room selectedRoom = RoomsList.SelectedItem as Room;

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

        private void SetWelcomeMessageTool_Click(object sender, EventArgs e)
        {
            using (WelcomeForm welcome = new WelcomeForm())
            {
                if (welcome.ShowDialog() == DialogResult.OK)
                {
                    viewModel.WelcomeMessage.Replace(WelcomeText.Text, welcome.NewMessage);
                    WelcomeText.Text = welcome.NewMessage;
                    viewModel.WelcomeMessage = WelcomeText.Text;
                }
            }
        }

        private void StartingLocationComboBox_BindingContextChanged(object sender, EventArgs e)
        {
            StartingLocationComboBox.DataSource = new BindingSource { DataSource = RoomsList.DataSource };
            if(StartingLocationComboBox.DisplayMember == null)
            {
                StartingLocationComboBox.DisplayMember = viewModel.StartingLocation;
            }
        }

        private void SaveFileToolStripMenu_Click(object sender, EventArgs e)
        {
            string filename = "TestFile.json";
            viewModel.SaveWorld(filename);
        }

        private void RoomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var control in neighborsControlsMap.Values)
            {
                Room selectedRoom = RoomsList.SelectedItem as Room;

                control.Rooms = selectedRoom;
            }
        }

        private void NewFileToolStripMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Wish to Start A New Zork World?", AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                viewModel.Rooms = new BindingList<Room>(Array.Empty<Room>());
                viewModel.StartingLocation = null;
                viewModel.WelcomeMessage = "Welcome to Zork!";
                WorldIsLoaded = true;
            }
        }
    }
}
