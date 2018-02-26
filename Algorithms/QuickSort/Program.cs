using static System.Console;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 7, 5, 8, 4, 1, 9, 6 };

            WriteLine("Initial array items: ");
            Output(arr);

            Sort(arr);
            WriteLine("Sorted array items using quick sort: ");
            Output(arr);


            ReadKey(true);
        }

        static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Write(a[i] + " ");
            }
            WriteLine();
        }

        static void Sort(int[] a)
        {
            Sort(a, 0, a.Length - 1);
        }

        static void Sort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] > num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            Sort(a, start, i - 1);
            Sort(a, i + 1, end);
        }
    }
}
