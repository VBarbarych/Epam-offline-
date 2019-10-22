using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfIOStream.Task2
{
    class FIndFile
    {
        private IWriteReadable WriteReadOfData;
        private ILogging logger;

        public FIndFile(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        
        public void FindFileInDirectories(DirectoryInfo root, string nameOfFile)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
           
            try
            {

                files = root.GetFiles($"{nameOfFile}*.txt");
            }
            catch (UnauthorizedAccessException e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {

                    WriteReadOfData.Write(fi.FullName);
                    WriteReadOfData.Write(" ");

                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    FindFileInDirectories(dirInfo, nameOfFile);
                }
            }
            else
                WriteReadOfData.Write("Directory is empty");
        }
    }
}
