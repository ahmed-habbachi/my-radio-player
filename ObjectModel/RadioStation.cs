using System;

namespace MyBrain.Applications.MyRadioPlayer.ObjectModel
{
    public class RadioStation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string StreamingSource { get; set; }
        public string Logo { get; set; }
        public int Ordre { get; set; }

        public Uri StreamingURI
        {
            get
            {
                return new Uri(StreamingSource);
            }
        }

        public RadioStation()
        {
            this.Id = Guid.NewGuid().ToString();

        }
    }
}
