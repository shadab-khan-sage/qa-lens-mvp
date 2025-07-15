namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World1!");
            Console.WriteLine("Hello, World2!");
            int sum = Add(5, 3);
            int difference = Subtract(5, 3);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;

        }
    }
}
