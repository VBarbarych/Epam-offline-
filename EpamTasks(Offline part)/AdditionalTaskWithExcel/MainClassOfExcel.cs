using System;
using System.Collections.Generic;
using System.Configuration;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskWithExcel
{
    public class MainClassOfExcel : IRunable
    {
        private string path;
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfExcel(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void Run()
        {
            ImplementTaskWithExcel();
        }

        public void ImplementTaskWithExcel()
        {
            writeReadOfData.Write("\n\n=============Additional Task with Excel File==============");
            try
            {
                ExcelData excelData = new ExcelData();

                string firstColumn = ConfigurationManager.AppSettings.Get("FirstColumn");
                string secondColumn = ConfigurationManager.AppSettings.Get("SecondColumn");
                path = ConfigurationManager.AppSettings.Get("ExcelFilePath"); // path from App.config

                HashSet<string> uniqueElementsFromFirstColumn = new HashSet<string>();
                HashSet<string> uniqueElementsFromSecondColumn = new HashSet<string>();

                uniqueElementsFromFirstColumn = excelData.Read(path, firstColumn);
                uniqueElementsFromSecondColumn = excelData.Read(path, secondColumn);
                excelData.Output(writeReadOfData, uniqueElementsFromFirstColumn, uniqueElementsFromSecondColumn);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }
    }
}
