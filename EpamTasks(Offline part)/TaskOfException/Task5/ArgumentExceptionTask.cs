using LibraryOfInterfacesAndClasses.AdditionalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfException
{
    class ArgumentExceptionTask
    {
        ConsoleData consoleData = new ConsoleData();

        public void DoSomeMath()
        {
            int a = Convert.ToInt32(consoleData.Read());
            if (a < 0)
            {
                throw new ArgumentException("Parameter should be greater than 0", "a");
            }

            int b = Convert.ToInt32(consoleData.Read());
            if (b > 0)
            {
                throw new ArgumentException("Parameter should be less than 0", "b");
            }
        }
    }
}
