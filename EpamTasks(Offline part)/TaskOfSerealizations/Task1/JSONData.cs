using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TaskOfSerealizations.Task1
{
    class JSONData
    {
        public void Serialization(List<Car> car)
        {
            using (StreamWriter fs = File.CreateText(@"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfSerealizations\bin\Debug\movie.json"))
            {

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(fs, car);
            }

        }

        public List<Car> Deserialization()
        {
            using (StreamReader file = File.OpenText(@"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfSerealizations\bin\Debug\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Car> dList = (List<Car>)serializer.Deserialize(file, typeof(List<Car>));
                return dList;
            }
        }
    }
}
