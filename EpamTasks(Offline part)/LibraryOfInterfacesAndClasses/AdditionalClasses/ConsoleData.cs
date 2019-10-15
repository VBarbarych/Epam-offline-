using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfInterfacesAndClasses.AdditionalClasses
{
    public class ConsoleData : IWriteReadable
    {
        public object Read()
        {
            object str = Console.ReadLine();
            return str;
        }
        
        public void Write(object data)
        {
            Console.WriteLine(data);
        }
    }
}
