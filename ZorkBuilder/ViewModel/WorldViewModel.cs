using System;
using System.ComponentModel;
using Zork.World;

namespace ZorkBuilder.ViewModel
{
   public class WorldViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool WorldIsLoaded { get; set; }

        public BindingList<Rooms> Rooms { get; set; }

        public BindingList<Neighbors> Neighbors { get; set; }

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
                       
                    }
                    else
                    {
                        Rooms = new BindingList<Rooms>(Array.Empty<Rooms>());
                        
                    }
                }
            }
        }
        private World world;
    }
}
