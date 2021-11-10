using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Zork
{
    public class World: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Room> Rooms { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomByName { get; set; }

        public World(IEnumerable<Room> rooms, IEnumerable<Room> neighbors, string Start, string welcomeMessage)
        {
            Rooms = new List<Room>(rooms);
            StartingLocation = Start;
            WelcomeMessage = welcomeMessage;
        }


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            RoomByName = new Dictionary<string, Room>();

            foreach (Room room in Rooms)
            {
                RoomByName.Add(room.Name, room);
            }

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
                room.BuildNeighborsFromName(Rooms);
            }
        }
    }
}
