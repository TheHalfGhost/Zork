using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.IO;
using Zork;
using System.Collections.Generic;

namespace ZorkBuilder.ViewModel
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool WorldIsLoaded { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public World World
        {
            set
            {
                if (world != value)
                {
                    world = value;

                    if (world != null)
                    {
                        Rooms = new BindingList<Room>(world.Rooms);
                        WelcomeMessage = world.WelcomeMessage;
                        StartingLocation = world.StartingLocation;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        WelcomeMessage = null;
                        StartingLocation = null;
                    }
                }
            }
        }

        public void SaveWorld(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidOperationException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, world);
            }
        }
        private World world;
    }
}
