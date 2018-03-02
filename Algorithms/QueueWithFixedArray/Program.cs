using static System.Console;

namespace QueueWithFixedArray
{
    class Program
    {
        private static int[] queue;
        private static int front;
        private static int rear;
        private static int max;

        static void Main(string[] args)
        {
            Write("Get queue maximum capacity: ");
            int n = int.Parse(ReadLine());

            queue = new int[n];
            front = 0;
            rear = -1;
            max = n;

            Enqueue(10);
            Enqueue(20);
            Enqueue(30);
            Enqueue(40);
            Enqueue(50);
            PrintQueue();

            Dequeue();
            Dequeue();
            Dequeue();
            PrintQueue();


            ReadKey(true);
        }

        public static void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                WriteLine("Queue overflow");
                return;
            }
            else
            {
                queue[++rear] = item;
            }
        }

        public static int Dequeue()
        {
            if (front == rear + 1)
            {
                WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                WriteLine("Deleted element is: " + queue[front]);
                return queue[front++];
            }
        }

        public static void PrintQueue()
        {
            if (front == rear + 1)
            {
                WriteLine("Queue is empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    WriteLine("Item[" + (i + 1) + "]: " + queue[i]);
                }
            }
        }
    }
}
