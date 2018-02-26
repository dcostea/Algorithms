using static System.Console;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Fibonacci numbers: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...");
            Write("Get n: ");
            int n = int.Parse(ReadLine());
            long previous = 1;
            long current = 1;
            long fibonacci = 0;

            for (int i = 2; i <= n; i++)
            {
                fibonacci = current + previous;
                previous = current;
                current = fibonacci;

            }

            WriteLine("Fibonacci (recursive) is: " + fibonacci);


            ReadKey(true);
        }

        static long Fibonacci(int n)
        {
            if (n == 0 || n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
