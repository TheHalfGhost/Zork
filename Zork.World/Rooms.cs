using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork.World
{
    public class Rooms : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors")]
        public Dictionary<NeighborLocations, string> NeighborNames { get; set; }

        [JsonIgnore]
        public Dictionary<NeighborLocations, Neighbors> NeighborsRooms { get; set; } 

        public Rooms(string name = null)
        {
            Name = name;
        }

        public void UpdateNieghbors(World world)
        {
            NeighborsRooms = new Dictionary<NeighborLocations, Neighbors>();
            foreach(var pair in NeighborNames)
            {
                (NeighborLocations neighborLocations, string name) = (pair.Key, pair.Value);
                NeighborsRooms.Add(neighborLocations, world.NeighborsByName[name]);
            }
        }
    }
}
