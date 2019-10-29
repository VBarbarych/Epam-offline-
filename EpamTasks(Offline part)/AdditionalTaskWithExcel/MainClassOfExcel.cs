using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using System.Diagnostics;
using Logger;

namespace TaskWithExcel
{
    public class MainClassOfExcel : IRunable
    {
        string path;
        private IWriteReadable WriteReadOfData;
        ILogging logger;

        public MainClassOfExcel(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void ImplementTaskWithExcel()
        {
            try
            {
                ExcelData xlsx = new ExcelData();

                string firstColumn = ConfigurationManager.AppSettings.Get("FirstColumn");
                string secondColumn = ConfigurationManager.AppSettings.Get("SecondColumn");
                path = ConfigurationManager.AppSettings.Get("ExcelFilePath"); //path from App.config

                HashSet<string> uniqueElementsFromFirstColumn = new HashSet<string>();
                HashSet<string> uniqueElementsFromSecondColumn = new HashSet<string>();

                uniqueElementsFromFirstColumn = xlsx.Read(path, firstColumn);
                uniqueElementsFromSecondColumn = xlsx.Read(path, secondColumn);
                xlsx.Output(WriteReadOfData, uniqueElementsFromFirstColumn, uniqueElementsFromSecondColumn);
            }
            catch(Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        public void Run()
        {
            Stopwatch sw_total = new Stopwatch();
            sw_total.Start();

            ImplementTaskWithExcel();

            sw_total.Stop();
            WriteReadOfData.Write("Execute time: " + sw_total.ElapsedMilliseconds + " ms");

        }


    }
}
