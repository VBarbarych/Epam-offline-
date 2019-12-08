using System;
using System.Collections.Generic;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskWithDirectories
{
    public class SearchFile
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;
        private List<FileInfo> allFilesinDirectories = new List<FileInfo>();

        public SearchFile(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public List<FileInfo> GetFilesFromDirectory(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
                allFilesinDirectories.AddRange(files);
            }
            catch (UnauthorizedAccessException e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }

            if (allFilesinDirectories != null)
            {
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

            return allFilesinDirectories;
        }

        public void OutputFile(List<string> listOfFile)
        {
            foreach (string fi in listOfFile)
            {
                writeReadOfData.Write(fi);
            }
        }

        public List<string> GetIdenticalFiles(List<string> listOfFile)
        {
            List<string> listOfIdenticalFiles = new List<string>();

            HashSet<string> hash = new HashSet<string>();
            foreach (string file in listOfFile)
            {
                if (!hash.Add(file))
                {
                    listOfIdenticalFiles.Add(file);
                }
            }

            return listOfIdenticalFiles;
        }

        public List<string> GetDistinctFiles(List<string> listOfFile)
        {
            List<string> listOFDistinctFiles = new List<string>();

            HashSet<string> hash = new HashSet<string>();
            foreach (string file in listOfFile)
            {
                if (hash.Add(file))
                {
                    listOFDistinctFiles.Add(file);
                }
            }

            return listOFDistinctFiles;
        }
    }
}
