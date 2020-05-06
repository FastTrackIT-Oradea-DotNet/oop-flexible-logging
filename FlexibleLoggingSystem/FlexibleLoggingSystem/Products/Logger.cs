namespace FlexibleLoggingSystem.Products
{
    public abstract class Logger
    {
        public void WriteLog(LogLevel level, string errorMessage)
        {
            WriteLog(level, errorMessage, string.Empty);
        }

        public abstract void WriteLog(LogLevel level, string errorMessage, string additionalInfo);
    }
}
