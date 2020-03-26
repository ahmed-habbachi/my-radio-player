using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBrain.Applications.MyRadioPlayer.ObjectModel
{
    public class Profile
    {
        public DateTime LastSave { get; set; } = DateTime.Now;
        public double WindowTop { get; set; } = 0;
        public double WindowLeft { get; set; } = 0;
        public double Volume { get; set; } = 0.5;
        public string LastRadioId { get; set; }
        public List<RadioStation> RadioStations { get; set; }
        public string Language { get; set; }
    }
}
