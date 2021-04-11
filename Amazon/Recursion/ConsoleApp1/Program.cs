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

        private static int frogways(int feet)
        {
            if (feet > 3) { return frogways(feet - 1) + frogways(feet - 2); }
            else if(feet == 3) { return 3; }
            else return 2;
        }

        static void Main(string[] args)
        {
            //var result = factorial(4);
            //var result = fibonacci(8);
            var result = frogways(3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
