using static System.Console;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Get palindrome: ");
            string s = ReadLine();

            int min = 0;
            int max = s.Length - 1;
            bool isPalindrome = true;

            while (true)
            {
                if (min > max)
                {
                    break;
                }

                if (s[min] == ' ')
                {
                    min++;
                }

                if (s[max] == ' ')
                {
                    max--;
                }

                if (s[min] != s[max])
                {
                    isPalindrome = false;
                }

                min++;
                max--;
            }

            if (isPalindrome)
            {
                WriteLine(s + " is a palindrome.");
            }
            else
            {
                WriteLine(s + " is NOT a palindrome.");
            }


            ReadKey(true);
        }
    }
}
