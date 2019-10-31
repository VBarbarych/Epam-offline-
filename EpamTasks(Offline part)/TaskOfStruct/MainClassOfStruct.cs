using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOfStruct.Task1;
using TaskOfStruct.Task2;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfStruct
{
    public class MainClassOfStruct : IRunable
    {
        private IWriteReadable WriteReadOfData;
        private ILogging logger;

        public MainClassOfStruct(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        private void ImplementOfTask1()
        {

            Person person = new Person("Tom", "Carry", 34);

            WriteReadOfData.Write("\n\n==========Struct==========\n");
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
