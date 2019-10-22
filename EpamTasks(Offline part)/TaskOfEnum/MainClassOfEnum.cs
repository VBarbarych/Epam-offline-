using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfEnum.Task1;
using TaskOfEnum.Task2;
using TaskOfEnum.Task3;

namespace TaskOfEnum
{
    public class MainClassOfEnum : IRunable
    {
        private IWriteReadable WriteReadOfData;
        ILogging logger;

        public MainClassOfEnum(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        private void ImplementOfTask1()
        {
            WriteReadOfData.Write("\n==========Enum==========\n");
            WriteReadOfData.Write("====Implement Task1=====\n");

            int month = 0;
            try
            {
                WriteReadOfData.Write("Input your month(number): ");
                month = Convert.ToInt32(WriteReadOfData.Read());
                if (month < 0 || month > 12)
                    throw new Exception("Error");
            }
            catch (Exception e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }

            WriteReadOfData.Write(Enum.GetName(typeof(Month), month));
        }

        private void ImplementOfTask2()
        {
            WriteReadOfData.Write("\n====Implement Task2=====\n");

            var color = Color.Green;
            color.EnumColorSort();
        }

        private void ImplementOfTask3()
        {
            WriteReadOfData.Write("\n====Implement Task3=====\n");

            WriteReadOfData.Write($"\n{(long)LongRange.Max} - max value \n{(long)LongRange.Min} - min value");
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
            ImplementOfTask3();
        }

    }
}
