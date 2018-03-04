using static System.Console;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Leap years:");

            const int START_YEAR = 2000;
            const int END_YEAR = 2500;

            for (int i = START_YEAR; i < END_YEAR; i++)
            {
                if (IsLeap(i))
                {
                    Write(i + " ");
                }
            }

            WriteLine();
            WriteLine();

            var n = (END_YEAR - START_YEAR) / 4;
            for (int i = 0; i <= n; i++)
            {
                if (IsLeapOptimized(i))
                {
                    Write(i * 4 + START_YEAR + " ");
                }
            }

            ReadKey(true);
        }

        static bool IsLeap(int n)
        {
            if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsLeapOptimized(int n)
        {
            if ((n % 25 != 0) || (n % 100 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
