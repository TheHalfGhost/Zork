using System.Windows.Forms;
using Zork;

namespace ZorkBuilder.Controls
{
    public partial class NeighborsUserControl : UserControl
    {
        private static readonly Room NoNeighbor = new Room("None") { Name = "None" };

        private Room rooms;

        private Directions neighborLocations;

        public Room NeighborsNames
        {
            get => (Room)NeighborsComboBox.SelectedItem;
            set => NeighborsComboBox.SelectedItem = value;
        }

        public Room Rooms
        {
            get => rooms;

            set
            {
                if (rooms != value)
                {
                    rooms = value;

                    if (rooms != null)
                    {

                    }
                    else
                    {
                        NeighborsComboBox.DataSource = null;
                    }
                }
            }
        }

        public Directions NeighborLocations
        {
            get => neighborLocations;

            set
            {
                neighborLocations = value;

                DirectionText.Text = neighborLocations.ToString();
            }
        }

        public NeighborsUserControl()
        {
            InitializeComponent();
        }
    }
}
