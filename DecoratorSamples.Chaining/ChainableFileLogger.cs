using System;
using System.IO;
using DecoratorSamples.Library;

namespace DecoratorSamples.Chaining
{
    public class ChainableFileLogger : FileLogger, ILogger
    {
        private readonly ILogger _baseLogger;

        public ChainableFileLogger(ILogger logger)
        {
            _baseLogger = logger;
        }

        public override void Log(string text)
        {
            Console.WriteLine($"Executing {_baseLogger.GetType()}");
            _baseLogger.Log(text);

            Console.WriteLine($"Executing {base.GetType()}");
            base.Log(text);
        }
    }
}

