using System;
using DecoratorSamples.Library;

namespace DecoratorSamples.Extending
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this project, let's "extend" the behaviour of our logger services by enclosing the text to log
            // within HTML tags.

            var consoleLogger = new ConsoleLogger();
            var fileLogger = new FileLogger();

            new HtmlLogger(consoleLogger, "span").Log("I'm written to the console!");
            new HtmlLogger(fileLogger, "div").Log("I'm written to a file!");

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}

