using System;
using System.Configuration;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfIOStream.Task2
{
    public class SearchFile
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public SearchFile(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void GetFileFromDirectories(DirectoryInfo root, string nameOfFile)
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
                    writeReadOfData.Write(fi.FullName);
                    writeReadOfData.Write(" ");
                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    GetFileFromDirectories(dirInfo, nameOfFile);
                }
            }
            else
            {
                writeReadOfData.Write("Directory is empty");
            }
        }

        public void SearchFileInDirectories()
        {
            DirectoryInfo dirInfo;
            try
            {
                string pathForDirectory = ConfigurationManager.AppSettings.Get("TaskOfIOStream2"); // path from App.config;

                dirInfo = new DirectoryInfo(pathForDirectory);

                writeReadOfData.Write("Find file with name[On example: 'text']: ");
                string nameOfFile = "text";

                GetFileFromDirectories(dirInfo, nameOfFile);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }
    }
}
