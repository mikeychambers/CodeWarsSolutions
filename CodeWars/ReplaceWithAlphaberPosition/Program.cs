using System;
using System.Collections.Generic;

/// <summary>
/// Replace every letter of an inputted string with its position in the alphabet
/// </summary>

namespace ReplaceWithAlphaberPosition
{
    class Program
    {
        static void Main(string[] args)
        {

           Compare(CreateCharArray("My Name Is Mud"));

           
           char[] CreateCharArray(string str)
           {
                char[] charArray = str.ToLower().ToCharArray();
                charArray = Array.FindAll<char>(charArray, (c => char.IsLetter(c)));
                return charArray;
           }

            void Compare(char[] x)
            {
                int p = 0;

                Dictionary<char, int> alphaNumbers = new Dictionary<char, int>();
                for (char i = 'a'; i <= 'z'; i++)
                {
                    p++;
                    alphaNumbers.Add(i, p);
                }
                foreach (char item in x)
                {
                    Console.WriteLine(alphaNumbers[item]);
                    
                }
                Console.Read();

            }

        }


    }
    
    
}
