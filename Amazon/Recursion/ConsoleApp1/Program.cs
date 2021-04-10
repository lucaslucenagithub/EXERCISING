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
            if (position >= 3) 
            { 
                var positionValue = fibonacci(position - 1) + fibonacci(position - 2); 
                return positionValue; 
            }

            return 1;
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
