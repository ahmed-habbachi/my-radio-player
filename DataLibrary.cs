using MyBrain.Applications.MyRadioPlayer.ObjectModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyBrain.Applications.MyRadioPlayer
{
    public class DataLibrary
    {
        private readonly string _jsonRadioStationFile;

        public DataLibrary(string jsonRadioStationFile)
        {
            _jsonRadioStationFile = jsonRadioStationFile;
        }

        public Profile LoadProfile()
        {
            var serializer = new JsonSerializer();
            using (FileStream fs = File.Open(_jsonRadioStationFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            //using (var bs = Assembly.GetManifestResourceStream(_jsonRadioStationFile))
            using (var sr = new StreamReader(bs))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<Profile>(jsonTextReader);
            }
        }

        public void SaveProfile(Profile profile)
        {
            File.WriteAllText(_jsonRadioStationFile, JsonConvert.SerializeObject(profile, Formatting.Indented));
        }
    }
}
