using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Zork
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public string Music { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors {get; set;}

        [JsonIgnore]
        public List<Room> NeighborRooms { get; set; }

        [JsonProperty (PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborsNames { get; set; }

        public Room(string name = null, Dictionary<Directions, string> neighborsnames = null, List<string> neighborrooms = null, string image = null, string music = null)
        {
            Name = name;

            NeighborsNames = neighborsnames;

            NeighborRooms = new List<Room>();

            Picture = image;

            Music = music;
        }

        public void BuildNeighborsFromName(List<Room> rooms)
        {
            Neighbors = (from entry in NeighborsNames
                             let room = rooms.Find(i => i.Name.Equals(entry.Value, System.StringComparison.InvariantCultureIgnoreCase))
                             where room != null
                             select (Directions: entry.Key, Room: room)).ToDictionary(pair => pair.Directions, pair => pair.Room);


            NeighborsNames.Clear();
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