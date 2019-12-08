using System;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfEnum.Task1
{
    public class Month : IMonthReader, IMonthWriter
    {
        private int month;
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public Month(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void InputMonth()
        {
            month = 0;
            try
            {
                writeReadOfData.Write("Input your month(number): ");
                month = Convert.ToInt32(writeReadOfData.Read());
                if (month < 0 || month > 12)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }
        }

        public void OutputMonth()
        {
            writeReadOfData.Write(Enum.GetName(typeof(MonthOfYear), month));
        }
    }
}
