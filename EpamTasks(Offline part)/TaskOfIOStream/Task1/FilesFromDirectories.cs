using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibraryOfInterfacesAndClasses.AdditionalClasses;

namespace TaskOfIOStream.Task1
{
    public static class FileFromDirectories
    {
        

        public static void GetFilesFromDirectory(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            ConsoleData consoleData = new ConsoleData();

            try
            {
                files = root.GetFiles("*.*");
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
                    GetFilesFromDirectory(dirInfo);
                }

            }
            else
                consoleData.Write("Directory is empty");
        }
    }
}
