using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int factorial(int n)
        {
            if (n >= 1) { var val = n * factorial(n - 1); return val; }
            else { return 1; };
        }

        private static int fibonacci(int position)
        {
            if (position == 1 || position == 2) { return 1; }
            var positionValue = fibonacci(position - 1) + fibonacci(position - 2);
            return positionValue;
        }

        static void Main(string[] args)
        {
            //var result = factorial(4);
            var result = fibonacci(8);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
