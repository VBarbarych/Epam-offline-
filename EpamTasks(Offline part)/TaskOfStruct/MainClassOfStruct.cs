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
        private IWriteReadable WriteReadOfData;

        public MainClassOfStruct(IWriteReadable writeReadOfData)
        {
            this.WriteReadOfData = writeReadOfData;
        }

        private void ImplementOfTask1()
        {

            Person person = new Person("Tom", "Carry", 34);

            WriteReadOfData.Write("==========Struct==========\n");
            WriteReadOfData.Write("=====Implement Task1======\n");
            WriteReadOfData.Write(person.PrintOurString(33));
        }

        private void ImplementOfTask2()
        {
            WriteReadOfData.Write("\n=====Implement Task2======\n");
            Rectangle rectangle = new Rectangle(3, 2, 1, 1);
            WriteReadOfData.Write(rectangle.Perimeter());
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
        }
    }
}
