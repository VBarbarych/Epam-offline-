using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWithDirectories
{
    public class MainClassOfDirectories : IRunable
    {
        private IWriteReadable WriteReadOfData;
        ILogging logger;

        public MainClassOfDirectories(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void ImplementTaskWithDirectories()
        {
            WriteReadOfData.Write("\n\n=============Additional Task with Directories and file==============");


            ActionWithFile fileFromDirectories = new ActionWithFile(WriteReadOfData, logger);
            List<FileInfo> allFiles = new List<FileInfo>();
            List<string> allFilesFromDirectories = new List<string>();
            List<string> identicalFiles = new List<string>();
            List<string> distinctFiles = new List<string>();

            string path;

            DirectoryInfo dirInfo;
            try
            {
                path = ConfigurationManager.AppSettings.Get("TaskWithDirectories"); //path from App.config
                dirInfo = new DirectoryInfo(path);

                WriteReadOfData.Write("All file in your directory and subdirectories: \n");
                allFiles = fileFromDirectories.GetFilesFromDirectory(dirInfo);

                

                foreach (FileInfo fi in allFiles)
                {

                    allFilesFromDirectories.Add(Path.GetFileName(fi.ToString()));

                }

                fileFromDirectories.OutputFile(allFilesFromDirectories);

                identicalFiles = fileFromDirectories.GetIdenticalFiles(allFilesFromDirectories);
                WriteReadOfData.Write("\nIdentical files: ");
                fileFromDirectories.OutputFile(identicalFiles);
                WriteReadOfData.Write($"\nCount of Identical files: {identicalFiles.Count}");

                WriteReadOfData.Write("\nDistinct files: \n");
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
