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

namespace TaskOfIOStream
{
    public class MainClassOfIOStream : IRunable
    {
        ConsoleData consoleData = new ConsoleData();

        private void ImplementOfTask1()
        {
            consoleData.Write("\n========IO Stream=======\n");
            consoleData.Write("=====Implement Task1====\n");
            consoleData.Write("Show all file from directory, Input Yes or No");
            string conditional = (string)consoleData.Read();

            if (conditional == "Yes")
            {
                DirectoryInfo dirInfo;
                try
                {
                    string path = @"C:\Users\Comp\Documents\Visual Studio 2017\Projects\Epam1";

                    dirInfo = new DirectoryInfo(path);

                    consoleData.Write("All file in your directory and subdirectories: ");

                    FileFromDirectories.GetFilesFromDirectory(dirInfo);
                }
                catch (Exception ex)
                {
                    consoleData.Write(ex.Message);
                }
            }
        }

        private void ImplementOfTask2()
        {
            consoleData.Write("\n=====Implement Task2====\n");

            DirectoryInfo dirInfo;
            try
            {
                FIndFile file = new FIndFile();
                string path = @"C:\dir1";

                dirInfo = new DirectoryInfo(path);

                consoleData.Write("Your file: ");
                string nameOfFile = (string)consoleData.Read();

                file.FindFileInDirectories(dirInfo, nameOfFile);
            }
            catch (Exception ex)
            {
                consoleData.Write(ex.Message);
            }
        }

        public void Run()
        {
            ImplementOfTask1();
            ImplementOfTask2();
        }
    }
}
