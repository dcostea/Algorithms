using static System.Console;

namespace FactorialRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Get n: ");
            int n = int.Parse(ReadLine());

            WriteLine("Factorial (recursive) is: " + Factorial(n));


            ReadKey(true);
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1)  return 1;

            return n * Factorial(n - 1);
        }
    }
}
