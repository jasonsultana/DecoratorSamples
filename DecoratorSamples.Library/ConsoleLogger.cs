using System;
namespace DecoratorSamples.Library
{
    public class ConsoleLogger : ILogger
    {
        public virtual void Log(string text) => Console.WriteLine(text);
    }
}

