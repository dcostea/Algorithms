using static System.Console;

namespace FibonacciIterative
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
            long fibonacci = 2;

            for (int i = 2; i < n; i++)
            {
                fibonacci = current + previous;
                previous = current;
                current = fibonacci;
            }

            WriteLine("Fibonacci (iterative) is: " + fibonacci);


            ReadKey(true);
        }
    }
}
