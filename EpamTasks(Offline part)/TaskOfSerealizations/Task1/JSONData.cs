using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace TaskOfSerealizations.Task1
{
    public class JSONData
    {
        private string path = ConfigurationManager.AppSettings.Get("JSONFile"); // path from App.config

        public void Serialization(List<Car> car)
        {
            using (StreamWriter fs = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(fs, car);
            }
        }

        public List<Car> Deserialization()
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Car> dList = (List<Car>)serializer.Deserialize(file, typeof(List<Car>));
                return dList;
            }
        }
    }
}
