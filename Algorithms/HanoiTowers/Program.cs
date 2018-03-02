using static System.Console;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            char from = 'A'; // start tower in output
            char to = 'C'; // end tower in output
            char via = 'B'; // auxiliary tower in output
            int disks = 3; // number of disks

            Solve(disks, from, to, via);


            ReadKey(true);
        }

        private static void Solve(int n, char from, char to, char via)
        {
            if (n == 1)
            {
                WriteLine("move disk from " + from + " to " + to);
            }
            else
            {
                Solve(n - 1, from, via, to);
                Solve(1, from, to, via);
                Solve(n - 1, via, to, from);
            }
        }
    }
}
