using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfIOStream.Task1
{
    public class FileFromDirectories
    {
        private IWriteReadable WriteReadOfData;
        private ILogging logger;

        public FileFromDirectories(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }


        public void GetFilesFromDirectory(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            

            try
            {
                files = root.GetFiles("*.*");
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
                    GetFilesFromDirectory(dirInfo);
                }

            }
            else
                WriteReadOfData.Write("Directory is empty");
        }
    }
}
