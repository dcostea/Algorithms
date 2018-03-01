using static System.Console;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 6, 3, 4, 2 }; // 5 is missing

            WriteLine(MissingNumber(a));


            ReadKey();
        }

        public static int MissingNumber(int[] arr)
        {
            int sum = 0;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            int estimated = Sum(n);

            return estimated - sum;
        }

        public static int Sum(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
