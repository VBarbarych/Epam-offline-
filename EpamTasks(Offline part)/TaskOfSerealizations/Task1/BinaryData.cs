using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfSerealizations.Task1
{
    public class BinaryData
    {
        string path = ConfigurationManager.AppSettings.Get("BinaryFile"); // path from App.config

        public void Serialization(List<Car> car)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, car);
            }

        }

        public List<Car> Deserialization()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                List<Car> dList = (List<Car>)bf.Deserialize(fs);
                return dList;
            }
        }

    }
}
