using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalClasses;

namespace TaskOfIOStream.Task2
{
    class FIndFile
    {
        ConsoleData consoleData = new ConsoleData();

        
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
                consoleData.Write(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                consoleData.Write(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {

                    consoleData.Write(fi.FullName);
                    consoleData.Write(" ");

                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    FindFileInDirectories(dirInfo, nameOfFile);
                }
            }
            else
                consoleData.Write("Directory is empty");
        }
    }
}
