using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfInterfacesAndClasses.AdditionalClasses
{
    public class WriteReadData 
    {
        public IWriteReadable TypeOfWriteRead { get; set; }

        public WriteReadData(IWriteReadable typeOfWriteRead)
        {
            this.TypeOfWriteRead = typeOfWriteRead;
        }

        public void Write(object data)
        {
            TypeOfWriteRead.Write(data);
        }

        public void Read()
        {
            TypeOfWriteRead.Read();
        }
    }
}
