using System;

namespace FlexibleLoggingSystem
{
    public class ConsoleLogger : Logger
    {
        public override void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            Console.WriteLine($"{level}: {errorMessage}");

            if (!string.IsNullOrWhiteSpace(additionalInfo))
            {
                Console.WriteLine(additionalInfo);
            }
        }
    }
}
