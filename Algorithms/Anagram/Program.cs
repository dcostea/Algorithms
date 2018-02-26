using System;
using static System.Console;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter first word:");
            string first = ReadLine();
            Write("Enter second word:");
            string second = ReadLine();

            char[] firstAsCharArray = first.ToLower().ToCharArray();
            char[] secondAsCharArray = second.ToLower().ToCharArray();

            Array.Sort(firstAsCharArray);
            Array.Sort(secondAsCharArray);

            string newFirst = new string(firstAsCharArray);
            string newSecond = new string(secondAsCharArray);

            if (newFirst == newSecond)
            {
                WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", first, second);
            }
            else
            {
                WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", first, second);
            }


            ReadKey(true);
        }
    }
}
