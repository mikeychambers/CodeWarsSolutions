using System;
using System.Collections.Generic;
/// <summary>
/// Write a function which takes a list of strings and returns each line prepended by the correct number.
/// </summary>

namespace NumberLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string> { "a", "b", "c" };
            Number(lines);
            static List<string> Number(List<string> lines)
            {
                List<string> newLines = new List<string>();
                int i = 0;
                foreach (string item in lines)
                {
                    i++;
                    newLines.Add(i.ToString() + ": " + item);
                }

                return newLines;
            }
        }
    }
}
