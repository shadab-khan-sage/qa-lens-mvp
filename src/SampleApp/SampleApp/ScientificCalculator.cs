using System;

namespace SampleApp
{
    public static class ScientificCalculator
    {
        public static double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public static double SquareRoot(double value)
        {
            return Math.Sqrt(value);
        }

        public static double Sine(double angleRadians)
        {
            return Math.Sin(angleRadians);
        }

        public static double Cosine(double angleRadians)
        {
            return Math.Cos(angleRadians);
        }
    }
} 