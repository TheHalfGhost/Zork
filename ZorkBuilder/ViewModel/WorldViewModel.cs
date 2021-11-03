using System;
using System.ComponentModel;
using Zork.World;
using Newtonsoft.Json;
using System.IO;

namespace ZorkBuilder.ViewModel
{
   public class WorldViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool WorldIsLoaded { get; set; }

        public BindingList<Rooms> Rooms { get; set; }

        public BindingList<Neighbors> Neighbors { get; set; }

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
                        Rooms = new BindingList<Rooms>(world.Rooms);
                        Neighbors = new BindingList<Neighbors>(world.Neighbors);
                        WelcomeMessage = "Weclome to Zork!";
                        StartingLocation = "West of House";
                    }
                    else
                    {
                        Rooms = new BindingList<Rooms>(Array.Empty<Rooms>());
                        Neighbors = new BindingList<Neighbors>(Array.Empty<Neighbors>());
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
