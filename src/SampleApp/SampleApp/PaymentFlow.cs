using System;

namespace SampleApp
{
    public static class PaymentFlow
    {
        public static void ProcessPayment()
        {
            CommonOperations.LogOperation("Payment");
            Console.WriteLine("Processing payment...");
        }
    }
} 