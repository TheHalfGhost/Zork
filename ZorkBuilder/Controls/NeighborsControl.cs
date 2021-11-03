using Zork.World;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ZorkBuilder.Controls
{
    public partial class NeighborsControl : UserControl
    {
        private static readonly Neighbors NoNeighbor = new Neighbors() { Name = "None" };

        private Rooms rooms;  

        private NeighborLocations neighborLocations;

        public Neighbors NeighborsNames 
        { 
            get => (Neighbors)NeighborcomboBox.SelectedItem; 
            set => NeighborcomboBox.SelectedItem = value; 
        }

        public Rooms Rooms
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
                        NeighborcomboBox.DataSource = null;
                    }
                }
            }
        }

        public NeighborLocations NeighborLocations 
        { 
            get => neighborLocations;

            set
            {
                neighborLocations = value;

                DirectionBox.Text = neighborLocations.ToString();
            }
        }

        public NeighborsControl()
        {
            InitializeComponent();
        }
    }
}
