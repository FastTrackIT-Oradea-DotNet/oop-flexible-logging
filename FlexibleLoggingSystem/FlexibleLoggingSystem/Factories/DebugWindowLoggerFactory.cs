using FlexibleLoggingSystem.Configuration;
using FlexibleLoggingSystem.Products;

namespace FlexibleLoggingSystem.Factories
{
    public class DebugWindowLoggerFactory : LoggerFactory
    {
        public override Logger Create(LoggerConfiguration configuration)
        {
            if (configuration is DebugWindowLoggerConfiguration debugWindowLoggerConfig)
            {
                return new DebugWindowLogger();
            }

            return null;
        }
    }
}
