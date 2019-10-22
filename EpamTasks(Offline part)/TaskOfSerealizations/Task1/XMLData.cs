using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskOfSerealizations.Task1
{
    class XMLData
    {
        public void Serialization(List<Car> car)
        {
            using (FileStream fs = new FileStream(@"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfSerealizations\bin\Debug\sertest.xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Car>));
                ser.Serialize(fs, car);
            }
        }

        public List<Car> Deserialization()
        {

            using (FileStream fs = new FileStream(@"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfSerealizations\bin\Debug\sertest.xml", FileMode.Open))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Car>));
                List<Car> d2List = (List<Car>)ser.Deserialize(fs);
                return d2List;
            }

        }


    }
}
