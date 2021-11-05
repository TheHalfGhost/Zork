using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork
{
    public class RoomByName: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string NORTH { get; set; }

        public string SOUTH { get; set; }

        public string WEST { get; set; }

        public string EAST { get; set; }
    }
}