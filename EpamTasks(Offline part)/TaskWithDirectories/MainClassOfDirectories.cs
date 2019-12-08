using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskWithDirectories
{
    public class MainClassOfDirectories : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfDirectories(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void ImplementTaskWithDirectories()
        {
            writeReadOfData.Write("\n\n=============Additional Task with Directories and file==============");

            SearchFile fileFromDirectories = new SearchFile(writeReadOfData, logger);
            List<FileInfo> allFiles = new List<FileInfo>();
            List<string> allFilesFromDirectories = new List<string>();
            List<string> identicalFiles = new List<string>();
            List<string> distinctFiles = new List<string>();

            string path;

            DirectoryInfo dirInfo;
            try
            {
                path = ConfigurationManager.AppSettings.Get("TaskWithDirectories"); // path from App.config
                dirInfo = new DirectoryInfo(path);

                writeReadOfData.Write("All file in your directory and subdirectories: \n");
                allFiles = fileFromDirectories.GetFilesFromDirectory(dirInfo);

                foreach (FileInfo fi in allFiles)
                {
                    allFilesFromDirectories.Add(Path.GetFileName(fi.ToString()));
                }

                fileFromDirectories.OutputFile(allFilesFromDirectories);

                identicalFiles = fileFromDirectories.GetIdenticalFiles(allFilesFromDirectories);
                writeReadOfData.Write("\nIdentical files: ");
                fileFromDirectories.OutputFile(identicalFiles);
                writeReadOfData.Write($"\nCount of Identical files: {identicalFiles.Count}");

                writeReadOfData.Write("\nDistinct files: \n");
                distinctFiles = fileFromDirectories.GetDistinctFiles(allFilesFromDirectories);
                fileFromDirectories.OutputFile(distinctFiles);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        public void Run()
        {
            ImplementTaskWithDirectories();
        }
    }
}
