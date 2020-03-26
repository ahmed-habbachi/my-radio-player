using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBrain.Applications.MyRadioPlayer
{
    public static class Helper
    {
        public static class Configuration
        {
            public const string PHOTOFILTER = ".jpg|.gif|.png|.bmp|.jpe|.jpeg";
            public const string APPDATAFOLDERNAME = "B2pRadioPlayer";
            public const string APPDATAJSONFILENAME = "RadioStations.json";
            public const string DEFAULTFOLDERNAME = "DefaultStations";
            public static readonly string SPECIALFOLDERPATH = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            public static string AppDataFolderFullPath
            {
                get
                {
                    return System.IO.Path.Combine(SPECIALFOLDERPATH, APPDATAFOLDERNAME);
                }
            }

            public static string DefaultFolderFullPath
            {
                get
                {
                    return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), DEFAULTFOLDERNAME);
                }
            }

            public static string AppDataJSONFullPath
            {
                get
                {
                    return System.IO.Path.Combine(AppDataFolderFullPath, APPDATAJSONFILENAME);
                }
            }
        }

        public static class RadioStationXmlData
        {
            public const string Document = "Document";
            public const string Version = "version";
            public const string LastSave = "lastSave";
            public const string RadioStationsRoot = "RadioStations";
            public const string RadioStation = "RadioStation";
            public const string Id = "id";
            public const string Name = "name";
            public const string WebSite = "WebSite";
            public const string StreamingURL = "StreamingURL";
            public const string Logo = "Logo";
        }
    }
}
