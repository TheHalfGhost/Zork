using System.ComponentModel;
using System.Collections.Generic;

namespace Zork.World
{
    public class Rooms : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        public Rooms()
        {

        }

        public Rooms(string name = null)
        {
            Name = name;
        }
    }
}
