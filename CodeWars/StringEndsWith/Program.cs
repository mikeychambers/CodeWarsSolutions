using System;
/// <summary>
/// Complete the solution so that it returns true
/// if the first argument(string) passed in ends 
/// with the 2nd argument (also a string). 
/// </summary>

namespace StringEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            
            static bool Solution(string str, string ending)
            {
              return str.EndsWith(ending);
            }
        }
    }
}
