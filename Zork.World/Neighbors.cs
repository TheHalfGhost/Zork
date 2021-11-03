using System.ComponentModel;

namespace Zork.World
{
    public class Neighbors : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
    }
}
