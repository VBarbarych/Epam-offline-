using System;
using System.Configuration;
using System.IO;

namespace Logger
{
    /// <summary>
    ///  This class describe logging an exception.
    /// </summary>
    public class FileLogger : ILogging
    {
        private string pathForLogging = null;
        private StreamWriter sw;

        /// <summary>
        /// This method logs an exception.
        /// </summary>
        /// <param name="logLevel">Level of logging.</param>
        /// <param name="message">Exception message.</param>
        public void Log(LogLevel logLevel, string message)
        {
            try
            {
                pathForLogging = ConfigurationManager.AppSettings.Get("loggerFile"); // Path from App.config
                string str = string.Format(
                    "[{0}]: ({1}): {2}",
                    logLevel.ToString(),
                    DateTime.Now,
                    message);

                using (sw = new StreamWriter(pathForLogging + "\\log.txt", false))
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
}
