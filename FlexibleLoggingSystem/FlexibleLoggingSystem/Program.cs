using FlexibleLoggingSystem.Configuration;
using FlexibleLoggingSystem.Factories;
using System;

namespace FlexibleLoggingSystem
{
    class Program
    {
        private static readonly LoggerFactory[] AvailableLoggers = new LoggerFactory[]
        {
            new ConsoleLoggerFactory(),
            new DebugWindowLoggerFactory(),
            new TextFileLoggerFactory()
        };

        static void Main(string[] args)
        {
            ApplicationLog.ConfigureLogger(new TextFileLoggerConfigration(@"D:\FastTrackIT\Temp"), AvailableLoggers);

            int i = 10;
            int j = 0;

            try
            {
                int result = i / j;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                ApplicationLog.WriteLog(LogLevel.Critical, ex.Message, ex.StackTrace);
            }
        }
    }
}
