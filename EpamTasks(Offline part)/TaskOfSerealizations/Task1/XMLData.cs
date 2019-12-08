using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskOfSerealizations.Task1
{
    class XMLData
    {
        string path = ConfigurationManager.AppSettings.Get("XMLFile"); //path from App.config
        public void Serialization(List<Car> car)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Car>));
                ser.Serialize(fs, car);
            }
        }

        public List<Car> Deserialization()
        {

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Car>));
                List<Car> d2List = (List<Car>)ser.Deserialize(fs);
                return d2List;
            }

        }


    }
}
