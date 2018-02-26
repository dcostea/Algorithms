using static System.Console;

namespace BinarySearchIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 7, 5, 8, 4, 1, 9, 6 };
            WriteLine(BinarySearch(arr, 4, 1, 9));


            ReadKey(true);
        }

        public static int BinarySearch(int[] a, int key, int min, int max)
        {
            while (min < max)
            {
                int mid = ((max - min) / 2) + min;
                if (a[mid] < key)
                {
                    min = mid;
                }
                else if (key < a[mid])
                {
                    max = mid;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
