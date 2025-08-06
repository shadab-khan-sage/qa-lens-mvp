using System;

namespace SampleApp
{
    public static class ConnectorFlow
    {
        public static void Connect()
        {
            CommonOperations.LogOperation("Connector");
            Console.WriteLine("Connecting to external service...");
        }
    }
} 