using System;
using DecoratorSamples.Library;

namespace DecoratorSamples.Extending
{
    public class HtmlLogger : ILogger
    {
        private readonly ILogger _baseLogger;
        private readonly string _enclosingTag;

        public HtmlLogger(ILogger baseLogger, string enclosingTag = "p")
        {
            _baseLogger = baseLogger;
            _enclosingTag = enclosingTag;
        }

        public void Log(string text)
        {
            var wrappedText = $"<{_enclosingTag}>{text}</{_enclosingTag}>";
            _baseLogger.Log(wrappedText);

            // Note: We can peform more actions after the wrapped component operation, too.
        }
    }
}
