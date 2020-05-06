namespace FlexibleLoggingSystem.Configuration
{
    public class TextFileLoggerConfigration : LoggerConfiguration
    {
        public TextFileLoggerConfigration(string pathToDir)
        {
            this.PathToDir = pathToDir;
        }

        public string PathToDir { get; }
    }
}
