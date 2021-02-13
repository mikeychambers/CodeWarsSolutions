using System;

namespace DetectPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                                "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            string sentance = "The quick brown fox jumps over the lazy dog.";
            sentance.ToLower();

            foreach (string let in letters)
            {
                if (sentance.Contains(let))
                {
                    x++;

                }
            }

            if (x == letters.Length)
            {
                Console.WriteLine("True {0}", x);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("False{0}", x);
                Console.ReadLine();
            }

        }
    }
}
