using System.ComponentModel;

namespace Zork.World
{
    public class Neighbors : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string NORTH { get; set; }

        public string SOUTH { get; set; }

        public string EAST { get; set; }

        public string WEST { get; set; }
    }
}
