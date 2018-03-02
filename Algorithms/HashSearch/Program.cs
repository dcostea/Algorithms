using static System.Console;

namespace HashSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "orange", "apricot", "kiwi", "cherry", "banana", "grape", "lemon", "mango", "pear", "plum" };
            string[] hashTable = new string[125 * 7]; // maximize the size using max char position in UniCode table multiplied by largest word size
            hashTable = Hashing(hashTable, words);

            WriteLine(GetElement(hashTable, "apple"));
            WriteLine(GetElement(hashTable, "apricot"));


            ReadKey(true);
        }

        static string[] Hashing(string[] h, string[] w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                int offset = 0;
                while (h[GetCustomHashCode(w[i]) + offset] != null)
                {
                    offset++;
                }
                h[GetCustomHashCode(w[i]) + offset] = w[i];
            }

            return h;
        }

        static int GetCustomHashCode(string s)
        {
            int hash = 0;

            for (int i = 0; i < s.Length; i++)
            {
                hash += s[i];
            }

            return hash;
            //return s[0];
        }

        static string GetElement(string[] h, string s)
        {
            int offset = 0;
            while (h[GetCustomHashCode(s) + offset] != s)
            {
                offset++;
            }

            return h[GetCustomHashCode(s) + offset];
        }
    }
}
