using System;
using DecoratorSamples.Library;

namespace DecoratorSamples.Chaining
{
    public class ChainableConsoleLogger : ConsoleLogger, ILogger
    {
        private readonly ILogger _baseLogger;

        public ChainableConsoleLogger(ILogger logger)
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

