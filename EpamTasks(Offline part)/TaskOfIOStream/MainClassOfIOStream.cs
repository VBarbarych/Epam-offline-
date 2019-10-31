using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System.IO;
using TaskOfIOStream.Task1;
using TaskOfIOStream.Task2;
using Logger;

namespace TaskOfIOStream
{
    public class MainClassOfIOStream : IRunable
    {
        private IWriteReadable WriteReadOfData;
        private ILogging logger;

        public MainClassOfIOStream(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        private void ImplementOfTask1()
        {
            FileFromDirectories fileFromDirectories = new FileFromDirectories(WriteReadOfData, logger);

            WriteReadOfData.Write("\n========IO Stream=======\n");
            WriteReadOfData.Write("=====Implement Task1====\n");
            WriteReadOfData.Write("Show all file from directory: ");
            
            
            DirectoryInfo dirInfo;
            try
            {
                string path = @"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfIOStream";

                dirInfo = new DirectoryInfo(path);

                WriteReadOfData.Write("All file in your directory and subdirectories: \n");

                fileFromDirectories.GetFilesFromDirectory(dirInfo);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        private void ImplementOfTask2()
        {
            WriteReadOfData.Write("\n=====Implement Task2====\n");

            DirectoryInfo dirInfo;
            try
            {
                FIndFile file = new FIndFile(WriteReadOfData, logger);
                string path = @"C:\Users\Comp\Documents\Epam-offline-\EpamTasks(Offline part)\TaskOfIOStream";

                dirInfo = new DirectoryInfo(path);

                WriteReadOfData.Write("Find file with name[On example: 'text']: ");
                string nameOfFile = "text";

                file.FindFileInDirectories(dirInfo, nameOfFile);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
        }
    }
}
