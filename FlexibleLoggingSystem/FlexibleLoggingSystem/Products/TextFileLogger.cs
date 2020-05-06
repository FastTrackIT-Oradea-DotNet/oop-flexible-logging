using System;
using System.IO;
using System.Text;

namespace FlexibleLoggingSystem.Products
{
    public class TextFileLogger : Logger
    {
        public TextFileLogger()
            : this(string.Empty)
        {
        }

        public TextFileLogger(string pathToDir)
        {
            if (string.IsNullOrWhiteSpace(pathToDir) || (!Directory.Exists(pathToDir)))
            {
                pathToDir = Path.GetTempPath();
            }

            this.PathToDir = pathToDir;
        }

        public string PathToDir { get; }

        public override void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            DateTime nowDate = DateTime.Now;
            string fileName = $"err{nowDate.Year}{nowDate.Month.ToString().PadLeft(2, '0')}{nowDate.Day.ToString().PadLeft(2, '0')}.txt";
            string fullPath = Path.Combine(this.PathToDir, fileName);

            using (StreamWriter sw = File.AppendText(fullPath))
            {
                StringBuilder errorLogEntry = new StringBuilder();
                errorLogEntry.AppendLine($"{level}: {errorMessage}");

                if (!string.IsNullOrWhiteSpace(additionalInfo))
                {
                    errorLogEntry.AppendLine(additionalInfo);
                }

                sw.WriteLine(errorLogEntry.ToString());
            }
        }
    }
}
