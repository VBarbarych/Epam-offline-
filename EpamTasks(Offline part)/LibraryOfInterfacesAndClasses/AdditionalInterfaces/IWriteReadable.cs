using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfInterfacesAndClasses.AdditionalInterfaces
{
    interface IWriteReadable
    {
        object Read();
        void Write(object data);
    }
}
