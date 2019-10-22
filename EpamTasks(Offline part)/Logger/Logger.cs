using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Logger
{
    public class FileLogger : ILogging
    {
        private string path = null;
        private StreamWriter sw;

        public void Log(LogLevel logLevel, string Mesage)
        {
            try
            {
                path = ConfigurationManager.AppSettings.Get("DestFolder"); //path from App.config
                string str = string.Format("[{0}]: ({1}): {2}",
                                            logLevel.ToString(),
                                            DateTime.Now,
                                            Mesage
                                            );

                using (sw = new StreamWriter(path + "\\log.txt", false))
                {
                    sw.WriteLine(str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }



        }
















    }



























    //public class ExceptionLogger : ILogging
    //{
    //    private string path = null;
    //    StreamWriter sw;

    //    public void Write(string message)
    //    {

    //        try
    //        {
    //            path = ConfigurationManager.AppSettings.Get("DestFolder"); //path from App.congif

    //            using (sw = new StreamWriter(path + "\\log.txt", false))
    //            {
    //                sw.WriteLine(String.Format("{0,-23} {1}", DateTime.Now.ToString() + ":", message));
    //            }
    //        }
    //        catch (Exception ex)
    //        {

    //        }
    //        finally
    //        {
    //            sw.Close();
    //        }
    //    }
    //}

}
