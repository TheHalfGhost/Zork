using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors {get; set;}

        [JsonProperty (PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborsNames { get; set; }

        public Room(string name = null, Dictionary<Directions, string > neighbors = null)
        {
            Name = name;

            NeighborsNames = neighbors;
        }

        public override string ToString() => Name;

        public void UpdateNeighbors(World world)
        {
            Neighbors = new Dictionary<Directions, Room>();

            foreach (var pair in NeighborsNames)
            {
                (Directions directions, string name) = (pair.Key, pair.Value);
                Neighbors.Add(directions, world.RoomByName[name]);
            }
        }
    }
}