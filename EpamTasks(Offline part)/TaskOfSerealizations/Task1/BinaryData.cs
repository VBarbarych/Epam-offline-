using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfSerealizations.Task1
{
    class BinaryData
    {

        public void Serialization(List<Car> car)
        {
            using (FileStream fs = new FileStream(@"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfSerealizations\bin\Debug\binary.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, car);
            }

        }

        public List<Car> Deserialization()
        {
            using (FileStream fs = new FileStream(@"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfSerealizations\bin\Debug\binary.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                List<Car> dList = (List<Car>)bf.Deserialize(fs);
                return dList;
            }
        }

    }
}
