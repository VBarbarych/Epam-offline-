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
        public IWriteReadable TypeOfWriteReadData { get; set; }

        public WriteReadData(IWriteReadable typeOfWriteReadData)
        {
            this.TypeOfWriteReadData = typeOfWriteReadData;
        }

        public void Write(object OutputData)
        {
            TypeOfWriteReadData.Write(OutputData);
        }

        public void Read()
        {
            TypeOfWriteReadData.Read();
        }
    }
}
