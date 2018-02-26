using static System.Console;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 7, 5, 8, 4, 1, 9, 6 };

            WriteLine("Initial array items: ");
            Output(arr);

            Sort(arr);
            WriteLine("Sorted array items using selection sort: ");
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
            int min;

            for (int j = 0; j < a.Length - 1; j++)
            {
                min = j;

                for (int i = j + 1; i < a.Length; i++)
                {
                    if (a[i] < a[min])
                    {
                        min = i;
                    }
                }

                aux = a[min];
                a[min] = a[j];
                a[j] = aux;
            }
        }
    }
}