using System;
using System.Configuration;
using System.IO;
  
namespace Elevator
{
    public class Logger
    {
        //Singleton
        private Logger()
        {
        }
        private static readonly object padlock = new object();
        private static Logger instance = null;
        private static readonly string dir = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("LogDir")) ? AppDomain.CurrentDomain.BaseDirectory : ConfigurationManager.AppSettings.Get("LogDir");

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }
        public static void Log(string message, LogType logType)
        {
            string filePath = dir + "log.txt";
              
            using (var tw = new StreamWriter(filePath, File.Exists(filePath)))
            {
                tw.WriteLine(string.Format("{0} : {1} : {2}", DateTime.Now.ToString(), logType.ToString(), message) );
            }
        }
    }
}
