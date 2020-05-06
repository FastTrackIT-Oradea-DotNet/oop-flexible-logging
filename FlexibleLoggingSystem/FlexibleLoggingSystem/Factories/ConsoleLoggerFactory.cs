using FlexibleLoggingSystem.Configuration;
using FlexibleLoggingSystem.Products;

namespace FlexibleLoggingSystem.Factories
{
    public class ConsoleLoggerFactory : LoggerFactory
    {
        public override Logger Create(LoggerConfiguration configuration)
        {
            if (configuration is ConsoleLoggerConfiguration consoleLoggerConfig)
            {
                return new ConsoleLogger();
            }

            return null;
        }
    }
}
