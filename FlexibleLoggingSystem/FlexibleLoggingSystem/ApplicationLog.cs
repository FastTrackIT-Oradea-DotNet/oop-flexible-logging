using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleLoggingSystem
{
    public static class ApplicationLog
    {
        private static Logger configuredLogger;

        public static Logger Logger 
        { 
            get
            {
                if (ApplicationLog.configuredLogger is null)
                {
                    return new ConsoleLogger();
                }

                return ApplicationLog.configuredLogger;
            }
        }

        public static void ConfigureLogger(Logger logger)
        {
            ApplicationLog.configuredLogger = logger;
        }

        public static void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            ApplicationLog.Logger.WriteLog(level, errorMessage, additionalInfo);
        }
    }
}
