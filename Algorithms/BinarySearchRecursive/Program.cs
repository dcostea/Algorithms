using static System.Console;

namespace BinarySearchRecursive
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
            if (min > max)
            {
                return -1;
            }

            int mid = ((max - min) / 2) + min;

            if (a[mid] < key)
            {
                return BinarySearch(a, key, mid, max);
            }
            else if (key < a[mid])
            {
                return BinarySearch(a, key, min, mid);
            }
            else
            {
                return mid;
            }
        }
    }
}
