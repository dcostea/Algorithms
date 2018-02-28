using static System.Console;

namespace FindDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 8, 7, 5, 8, 4, 1, 9, 6 };

            WriteLine("Initial array items: ");

            Sort(arr);

            var duplicate = FindDuplicate(arr);
            WriteLine(duplicate == -1 ? "No duplicate found" : "Found " + duplicate);


            ReadKey(true);
        }

        static int FindDuplicate(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[i + 1])
                {
                    return a[i];
                }
            }

            return -1;
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
