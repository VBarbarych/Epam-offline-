using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfInterfacesAndClasses.AdditionalClasses
{
    public class FileData : IWriteReadable
    {
        private string path;
        private string path1;
        StreamWriter sw;

        public object Read()
        {
            try
            {
                path1 = ConfigurationManager.AppSettings.Get("InputFile"); //path from App.config
                using (StreamReader sr = new StreamReader(path1 + "\\InputFile.txt", System.Text.Encoding.Default, false))
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        return line;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public void Write(object data)
        {
            path = ConfigurationManager.AppSettings.Get("OutputFile"); //path from App.config
            using (sw = new StreamWriter(path + "\\OutputFile.txt", true))
            {
                sw.WriteLine(data);
            }
        }

    }
}
