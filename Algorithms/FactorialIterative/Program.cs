using static System.Console;

namespace FactorialITerative
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Get n: ");
            int n = int.Parse(ReadLine());
            long factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }

            WriteLine("Factorial (iterative) is: " + factorial);


            ReadKey(true);
        }
    }
}
