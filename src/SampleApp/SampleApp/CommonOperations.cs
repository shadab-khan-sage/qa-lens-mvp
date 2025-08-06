using System;

namespace SampleApp
{
    public static class CommonOperations
    {
        public static void LogOperation(string operationName)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[{timestamp}] Operation performed: {operationName}");
        }
    }
} 