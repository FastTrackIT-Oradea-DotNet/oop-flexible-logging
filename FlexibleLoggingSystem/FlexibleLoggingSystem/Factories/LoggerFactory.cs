using FlexibleLoggingSystem.Configuration;
using FlexibleLoggingSystem.Products;

namespace FlexibleLoggingSystem.Factories
{
    public abstract class LoggerFactory
    {
        public abstract Logger Create(LoggerConfiguration configuration);
    }
}
