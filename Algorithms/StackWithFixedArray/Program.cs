using static System.Console;

namespace StackWithFixedArray
{
    class Program
    {
        private static int[] stack;
        private static int top;
        private static int max;

        static void Main(string[] args)
        {
            Write("Get stack maximum capacity: ");
            int n = int.Parse(ReadLine());

            stack = new int[n];
            top = -1;
            max = n;

            Push(10);
            Push(20);
            Push(30);
            Push(40);
            Push(50);
            WriteLine("Stack items are: ");
            PrintStack();

            Pop();
            Pop();
            Pop();
            WriteLine("Stack items are: ");
            PrintStack();


            ReadKey(true);
        }

        static void Push(int item)
        {
            if (top == max - 1)
            {
                WriteLine("Stack overflow");
                return;
            }
            else
            {
                stack[++top] = item;
            }
        }

        static int Pop()
        {
            if (top == -1)
            {
                WriteLine("Stack underflow");
                return -1;
            }
            else
            {
                WriteLine("Poped element is: " + stack[top]);
                return stack[top--];
            }
        }

        static void PrintStack()
        {
            if (top == -1)
            {
                WriteLine("Stack is empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    WriteLine("Item[" + (i + 1) + "]: " + stack[i]);
                }
            }
        }
    }
}
