using System;
using System.IO;
using System.Text;

namespace FlexibleLoggingSystem
{
    public class TextFileLogger : Logger
    {
        public TextFileLogger(string pathToDir)
        {
            if (!Directory.Exists(pathToDir))
            {
                pathToDir = Path.GetTempPath();
            }

            this.PathToDir = pathToDir;
        }

        public string PathToDir { get; }

        public override void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            DateTime nowDate = DateTime.Now;
            string fileName = $"err{nowDate.Year}{nowDate.Month}{nowDate.Day}.txt";
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
