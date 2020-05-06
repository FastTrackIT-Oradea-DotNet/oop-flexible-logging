using FlexibleLoggingSystem.Configuration;
using FlexibleLoggingSystem.Products;

namespace FlexibleLoggingSystem.Factories
{
    public class TextFileLoggerFactory : LoggerFactory
    {
        public override Logger Create(LoggerConfiguration configuration)
        {
            if (configuration is TextFileLoggerConfigration textFileLoggerConfig)
            {
                return new TextFileLogger(textFileLoggerConfig.PathToDir);
            }

            return null;
        }
    }
}
