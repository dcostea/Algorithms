using static System.Console;

namespace QueueWithCircularFixedArray
{
    class Program
    {
        private static int[] queue;
        private static int front;
        private static int rear;
        private static int max;
        private static int count;

        static void Main(string[] args)
        {
            Write("Get circular queue maximum capacity: ");
            int n = int.Parse(ReadLine());

            queue = new int[n];
            front = 0;
            rear = -1;
            max = n;
            count = 0;

            Enqueue(10);
            Enqueue(20);
            Enqueue(30);
            Enqueue(40);
            Enqueue(50);

            WriteLine("Items are: ");
            PrintQueue();

            Dequeue();
            Dequeue();

            Enqueue(60);
            Enqueue(70);

            WriteLine("Items are: ");
            PrintQueue();

            ReadKey(true);
        }

        public static void Enqueue(int item)
        {
            if (count == max)
            {
                WriteLine("Queue overflow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                queue[rear] = item;

                count++;
            }
        }

        public static void Dequeue()
        {
            if (count == 0)
            {
                WriteLine("Queue is empty");
            }
            else
            {
                WriteLine("Deleted element is: " + queue[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public static void PrintQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                WriteLine("Queue is empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    WriteLine("Item[" + (i + 1) + "]: " + queue[i]);

                    i = (i + 1) % max;
                    j++;
                }
            }
        }
    }
}
