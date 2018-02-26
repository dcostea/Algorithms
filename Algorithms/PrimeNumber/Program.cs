using static System.Console;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Get n: ");
            int n = int.Parse(ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    Write(i + " ");
                }
            }

            if (isPrime)
            {
                WriteLine(n + " is a prime number!");
            }
            else
            {
                WriteLine("factors found. " + n + " is not a prime number!");
            }


            ReadKey(true);
        }
    }
}
