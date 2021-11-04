using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Zork
{
    public class World
    {
        public Room[] Rooms { get; set; }

        public Dictionary<string, Room> RoomByName { get; private set; }

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
            }
        }
    }
}
