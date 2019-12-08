using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfStruct.Task1;
using TaskOfStruct.Task2;

namespace TaskOfStruct
{
    public class MainClassOfStruct : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfStruct(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
        }

        private void ImplementOfTask1()
        {
            writeReadOfData.Write("\n\n==========Struct==========\n");
            writeReadOfData.Write("=====Implement Task1======\n");

            Person person = new Person("Tom", "Carry", 34);
            writeReadOfData.Write(person.PrintString(33));
        }

        private void ImplementOfTask2()
        {
            writeReadOfData.Write("\n=====Implement Task2======\n");

            Rectangle rectangle = new Rectangle(3, 2, 1, 1);
            writeReadOfData.Write(rectangle.Perimeter());
        }
    }
}
