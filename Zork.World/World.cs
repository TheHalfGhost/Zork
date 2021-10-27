using System.Collections.Generic;
using System.ComponentModel;

namespace Zork.World
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Rooms> Rooms { get; }

        public List<Neighbors> Neighbors { get; }

        public World(IEnumerable<Rooms> rooms)
        {
            Rooms = new List<Rooms>(rooms);
        }
    }
}
