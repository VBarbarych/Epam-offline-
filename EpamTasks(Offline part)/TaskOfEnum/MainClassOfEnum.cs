using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using TaskOfEnum.Task1;
using TaskOfEnum.Task2;
using TaskOfEnum.Task3;

namespace TaskOfEnum
{
    public class MainClassOfEnum : IRunable
    {
        ConsoleData consoleData = new ConsoleData();

        private void ImplementOfTask1()
        {
            consoleData.Write("\n==========Enum==========\n");
            consoleData.Write("====Implement Task1=====\n");

            int month = 0;
            try
            {
                consoleData.Write("Input your month(number): ");
                month = Convert.ToInt32(consoleData.Read());
                if (month < 0 || month > 12)
                    throw new Exception("Error");
            }
            catch (Exception e)
            {
                consoleData.Write(e.Message);
            }

            consoleData.Write(Enum.GetName(typeof(Month), month));
        }

        private void ImplementOfTask2()
        {
            consoleData.Write("\n====Implement Task2=====\n");

            var color = Color.Green;
            color.EnumColorSort();
        }

        private void ImplementOfTask3()
        {
            consoleData.Write("\n====Implement Task3=====\n");

            consoleData.Write($"\n{(long)LongRange.Max} - max value \n{(long)LongRange.Min} - min value");
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
            ImplementOfTask3();
        }

    }
}
