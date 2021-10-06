using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        [JsonIgnore]
        public Room CurrentRoom { get; set; }

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

            return false;
        }

        public int Score = 0;

        public int Movement = 0;
    }
}
