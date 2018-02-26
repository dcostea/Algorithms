using static System.Console;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 7, 5, 8, 4, 1, 9, 6 };

            WriteLine("Initial array items: ");
            Output(arr);

            Sort(arr);
            WriteLine("Sorted array items using insertion sort: ");
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
            for (int j = 0; j < a.Length - 1; j++)
            {
                int aux = a[j];
                int ins = 0;

                for (int i = j - 1; i >= 0 && ins != 1;)
                {
                    if (aux < a[i])
                    {
                        a[i + 1] = a[i];
                        i--;
                        a[i + 1] = aux;
                    }
                    else
                    {
                        ins = 1;
                    }
                }
            }
        }
    }
}