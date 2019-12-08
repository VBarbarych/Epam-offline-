using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Configuration;
using System.IO;

namespace LibraryOfInterfacesAndClasses.AdditionalClasses
{
    public class FileData : IWriteReadable
    {
        private string pathForOutput;
        private string pathForInput;
        StreamWriter sw;

        public object Read()
        {
            try
            {
                pathForInput = ConfigurationManager.AppSettings.Get("InputFile"); // path from App.config
                using (StreamReader sr = new StreamReader(pathForInput + "\\InputFile.txt", System.Text.Encoding.Default, false))
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
            pathForOutput = ConfigurationManager.AppSettings.Get("OutputFile"); // path from App.config
            using (sw = new StreamWriter(pathForOutput + "\\OutputFile.txt", true))
            {
                sw.WriteLine(data);
            }
        }

    }
}
