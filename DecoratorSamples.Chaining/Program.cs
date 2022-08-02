using System;
using DecoratorSamples.Library;

namespace DecoratorSamples.Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: Look at DecoratorSamples.Extending first.
            // In this project, let's "chain" multiple decorators together
            // to create a pipeline.

            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();

            // Now create some simple chains...
            new ChainableFileLogger(consoleLogger).Log("Console, then file.");
            Console.WriteLine();

            new ChainableConsoleLogger(fileLogger).Log("File, then console.");
            Console.WriteLine();

            // Or we can create a complex one...
            new ChainableConsoleLogger(new ChainableFileLogger(consoleLogger)).Log("Console, file, then console again!");

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}

