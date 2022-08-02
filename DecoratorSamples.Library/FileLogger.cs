using System;
using System.IO;

namespace DecoratorSamples.Library
{
    public class FileLogger : ILogger
    {
        private static string LOG_PATH = "./log.txt";

        public virtual void Log(string text)
        {
            File.WriteAllText(LOG_PATH, text);
        }
    }
}

