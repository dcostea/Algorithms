using static System.Console;

namespace SecondLargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 10, 20, 40, 32, 44, 51, 6 };
            //WriteLine("Second largest Element : " + Find(A));
            WriteLine("Third largest Element : " + Find(A));


            ReadKey(true);
        }

        public static int Find(int[] a)
        {
            int first = a[0];
            int second = -1;
            int third = -1;

            for (int i = 1; i < a.Length; i++)
            {
                if (first < a[i])
                {
                    third = second;
                    second = first;
                    first = a[i];
                }
                else if (second < a[i])
                {
                    second = a[i];
                }
                else if (third < a[i])
                {
                    third = a[i];
                }
            }
            //return second;
            return third;
        }
    }
}
