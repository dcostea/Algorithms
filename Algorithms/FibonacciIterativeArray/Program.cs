using static System.Console;

namespace FibonacciIterativeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Fibonacci numbers: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...");
            Write("Get n: ");
            int n = int.Parse(ReadLine());

            int[] f = new int[n + 1];
            f[0] = 1;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            WriteLine("Fibonacci (iterative) numbers are: ");

            for (int i = 0; i < n; i++)
            {
                Write(f[i] + " ");
            }


            ReadKey(true);
        }
    }
}