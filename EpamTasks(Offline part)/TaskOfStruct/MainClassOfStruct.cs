using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOfStruct.Task1;
using TaskOfStruct.Task2;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;

namespace TaskOfStruct
{
    public class MainClassOfStruct : IRunable
    {
        ConsoleData consoleData = new ConsoleData();

        

        private void ImplementOfTask1()
        {
            Person person = new Person("Tom", "Carry", 34);

            consoleData.Write("==========Struct==========\n");
            consoleData.Write("=====Implement Task1======\n");
            consoleData.Write(person.PrintOurString(33));
        }

        private void ImplementOfTask2()
        {
            consoleData.Write("\n=====Implement Task2======\n");
            Rectangle rectangle = new Rectangle(3, 2, 1, 1);
            consoleData.Write(rectangle.Perimeter());
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
        }
    }
}
