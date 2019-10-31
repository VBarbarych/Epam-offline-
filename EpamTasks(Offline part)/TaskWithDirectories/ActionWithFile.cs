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
    public class ActionWithFile
    {
        private IWriteReadable WriteReadOfData;
        private ILogging logger;
        List<FileInfo> AllFilesinDirectories = new List<FileInfo>();
        List<string> list = new List<string>();

        public ActionWithFile(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.WriteReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public List<FileInfo> GetFilesFromDirectory(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
                AllFilesinDirectories.AddRange(files);
            }
            catch (UnauthorizedAccessException e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                logger.Log(LogLevel.Error, e.Message);
            }
            
            if (AllFilesinDirectories != null)
            {
                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    GetFilesFromDirectory(dirInfo);
                }
            }
            else
                WriteReadOfData.Write("Directory is empty");

            return AllFilesinDirectories;
        }

        public void OutputFile(List<string> listOfFile)
        {
            foreach (string fi in listOfFile)
            {

                WriteReadOfData.Write(fi);
                //WriteReadOfData.Write(" ");

            }
        }

        public List<string> GetIdenticalFiles(List<string> listOfFile)
        {
            List<string> list = new List<string>();

            HashSet<string> hash = new HashSet<string>();
            foreach (string file in listOfFile)
            {
                if (!hash.Add(file))
                {
                    list.Add(file);
                }
            }

            return list;
        }

        public List<string> GetDistinctFiles(List<string> listOfFile)
        {
            List<string> list = new List<string>();

            HashSet<string> hash = new HashSet<string>();
            foreach (string file in listOfFile)
            {
                if (hash.Add(file))
                {
                    list.Add(file);
                }
            }

            return list;
        }

    }
}
