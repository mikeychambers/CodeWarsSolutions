using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Given a string of words, return the length of the shortest word(s).
/// </summary>
namespace FindLengthOfShortestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            FindShort("Hello I am the lazer viking");
            static int FindShort(string s)
            {
                string[] array = s.Split();
                List<int> x = new List<int>();
                foreach (string item in array)
                {
                    x.Add(item.Length);
                }
                return x.Min(); 
            }
        }
    }
}
