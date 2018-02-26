using static System.Console;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 7, 5, 8, 4, 1, 9, 6 };

            WriteLine("Initial array items: ");
            Output(arr);

            Sort(arr);
            WriteLine("Sorted array items using bubble sort: ");
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
            int aux;

            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        aux = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = aux;
                    }
                }
            }
        }
    }
}
