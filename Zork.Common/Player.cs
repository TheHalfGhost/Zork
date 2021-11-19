using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace Zork
{
    public class Player: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public World World { get; }

        [JsonIgnore]
        public Room CurrentRoom { get; set; }

        [JsonIgnore]
        public string SetLocation
        {
            get
            {
                return CurrentRoom?.Name;
            }
            set
            {
                CurrentRoom = World?.RoomByName.GetValueOrDefault(value);
            }
        }

        public Room PerviousRoom { get; set; }

        public Player(World world, string startingLocation)
        {
            World = world;

            SetLocation = startingLocation;
        }

        public bool Move(Directions directions)
        {
            bool IsValidMove = CurrentRoom.Neighbors.TryGetValue(directions, out Room neighbor);

            if(IsValidMove)
            {
                CurrentRoom = neighbor;
            }

            return IsValidMove;
        }

        public int Score = 0;

        public int Movement = 0;
    }
}
