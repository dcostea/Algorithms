using static System.Console;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 7, 5, 8, 4, 1, 9, 6 };
            int pos = -1;

            Write("Get key: ");
            int key = int.Parse(ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (key == arr[i])
                {
                    pos = i;
                    break;
                }
            }

            if (pos >= 0)
            {
                WriteLine(key + " found at position " + pos);
            }
            else
            {
                WriteLine(key + " does not exist");
            }


            ReadKey(true);
        }
    }
}
