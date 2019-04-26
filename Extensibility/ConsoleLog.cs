using System;

namespace Extensibility
{
    public class ConsoleLog : Ilogger
    {
        public void LogError(string message)
        {
            Log(message);
        }

        public void LogInfo(string message)
        {
            Log(message);
        }
        private void Log(string message)
        {
            Console.WriteLine($" {message} {DateTime.Now}");
        }
    }
}
