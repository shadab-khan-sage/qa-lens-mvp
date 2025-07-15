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

        public static double Log10(double value)
        {
            return Math.Log10(value);
        }

        public static double Log(double value)
        {
            return Math.Log(value);
        }

        public static double Exp(double exponent)
        {
            return Math.Exp(exponent);
        }

        public static double Tangent(double angleRadians)
        {
            return Math.Tan(angleRadians);
        }

        public static double Abs(double value)
        {
            return Math.Abs(value);
        }

        public static double ArcSine(double value)
        {
            return Math.Asin(value);
        }

        public static double ArcCosine(double value)
        {
            return Math.Acos(value);
        }

        public static double ArcTangent(double value)
        {
            return Math.Atan(value);
        }

        public static long Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("Negative input not allowed for factorial.");
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
} 