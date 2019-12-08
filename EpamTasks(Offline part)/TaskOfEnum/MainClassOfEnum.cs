using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfEnum.Task1;
using TaskOfEnum.Task2;
using TaskOfEnum.Task3;

namespace TaskOfEnum
{
    public class MainClassOfEnum : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfEnum(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
            ImplementOfTask3();
        }

        private void ImplementOfTask1()
        {
            writeReadOfData.Write("\n==========Enum==========\n");
            writeReadOfData.Write("====Implement Task1=====\n");

            Month month = new Month(writeReadOfData, logger);
            month.InputMonth();
            month.OutputMonth();
        }

        private void ImplementOfTask2()
        {
            writeReadOfData.Write("\n====Implement Task2=====\n");

            Colors colors = new Colors(writeReadOfData, logger);
            colors.SortEnum();
            colors.OutputColors();
        }

        private void ImplementOfTask3()
        {
            writeReadOfData.Write("\n====Implement Task3=====\n");

            writeReadOfData.Write($"\n{(long)LongRange.Max} - max value \n{(long)LongRange.Min} - min value");
        }
    }
}
