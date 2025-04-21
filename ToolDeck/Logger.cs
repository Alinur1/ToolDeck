using System;
using System.IO;

namespace ToolDeck
{
    public static class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TooDeckErrLog.txt");

        public static void LogError(string message, Exception ex = null)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine("==== ERROR LOG ENTRY ====");
                    writer.WriteLine($"Date: {DateTime.Now}");
                    writer.WriteLine($"Message: {message}");

                    if (ex != null)
                    {
                        writer.WriteLine($"Exception: {ex.Message}");
                        writer.WriteLine($"StackTrace: {ex.StackTrace}");
                    }

                    writer.WriteLine("=========================\n");
                }
            }
            catch
            {
                // In case logging itself fails, silently ignore to avoid recursion/crash
            }
        }
    }
}
