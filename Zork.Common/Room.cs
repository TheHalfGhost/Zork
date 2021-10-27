using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Zork
{
    public class Room
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors {get; set;}

        [JsonProperty (PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborsNames { get; set; }

        public Room(string name, string description = "")
        {
            Name = name;
    
            Description = description;
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