using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork.World
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Rooms> Rooms { get; }

        public List<Neighbors> Neighbors { get; }

        public string StartingLocation { get; }

        [JsonIgnore]
        public Dictionary<string,Neighbors> NeighborsByName { get; private set; }

        public World(IEnumerable<Rooms> rooms, IEnumerable<Neighbors> neighbors)
        {
            Rooms = new List<Rooms>(rooms);
            Neighbors = new List<Neighbors>(neighbors);
        }

        [OnDeserialized]
        private void OnDeserizlized(StreamingContext context)
        {
            NeighborsByName = Neighbors.ToDictionary(neighbor => neighbor.Name, neighbors => neighbors);

            foreach (Rooms rooms in Rooms)
            {
                rooms.UpdateNieghbors(this);
            }
        }
    }
}
