using static System.Console;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int aux;
            WriteLine("x: " + x + " y: " + y);

            aux = x;
            x = y;
            y = aux;
            WriteLine("x: " + x + " y: " + y);

            x = x + y;
            y = x - y;
            x = x - y;
            WriteLine("x: " + x + " y: " + y);

            SwapNumbers(ref x, ref y);
            WriteLine("x: " + x + " y: " + y);


            ReadKey(true);
        }

        static void SwapNumbers(ref int a, ref int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;
        }
    }
}
