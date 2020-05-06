using FlexibleLoggingSystem.Configuration;
using FlexibleLoggingSystem.Factories;
using FlexibleLoggingSystem.Products;

namespace FlexibleLoggingSystem
{
    public static class ApplicationLog
    {
        private static Logger configuredLogger = null;

        private static Logger Logger
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

        public static void ConfigureLogger(LoggerConfiguration configuration, LoggerFactory[] availableFactories)
        {
            foreach (LoggerFactory factory in availableFactories)
            {
                Logger logger = factory.Create(configuration);

                if (logger != null)
                {
                    ApplicationLog.configuredLogger = logger;
                }
            }
        }

        public static void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            ApplicationLog.Logger.WriteLog(level, errorMessage, additionalInfo);
        }
    }
}
