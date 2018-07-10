namespace Logging
{
    using System.IO;

    public class Logging : ILogging
    {
        public void Log(string text)
        {
            InternalLog(text);
        }

        public void LogFormat(string text, params object[] p)
        {
            var message = string.Format(text, p);
            InternalLog(message);
        }

        private StreamWriter LogFile;

        private void InternalLog(string text)
        {
            if(LogFile == null)
            {
                LogFile = new StreamWriter("log.txt");
            }
            LogFile.WriteLine(text);
            LogFile.Flush();
        }
    }
}
