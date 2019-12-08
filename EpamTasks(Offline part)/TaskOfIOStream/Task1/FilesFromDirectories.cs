using System;
using System.Configuration;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfIOStream.Task1
{
    public class FileFromDirectories
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public FileFromDirectories(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
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
                    writeReadOfData.Write(fi.FullName);
                    writeReadOfData.Write(" ");
                }

                subDirs = root.GetDirectories();
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    GetFilesFromDirectory(dirInfo);
                }
            }
            else
            {
                writeReadOfData.Write("Directory is empty");
            }
        }

        public void OutputFilesFromDirectory()
        {
            DirectoryInfo dirInfo;
            try
            {
                string pathForDirectory = ConfigurationManager.AppSettings.Get("TaskOfIOStream1"); // Path from App.config

                dirInfo = new DirectoryInfo(pathForDirectory);

                writeReadOfData.Write("All file in your directory and subdirectories: \n");

                GetFilesFromDirectory(dirInfo);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }
    }
}
