using System;
using static System.Console;

namespace FibonacciRecursiveWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var nth = int.Parse(Console.ReadLine());
            WriteLine(FibonacciWithTuple(nth));

            ReadKey(true);
        }

        private static long FibonacciWithTuple(int x)
        {
            var result = Fibonacci(x);
            return result.current + result.previous;

            (long current, long previous) Fibonacci(int n) // Fibonacci as Function
            {
                if (n == 0) return (1, 0);
                var (current, previous) = Fibonacci(n - 1);

                return (checked(current + previous), current);
            }
        }
    }
}
