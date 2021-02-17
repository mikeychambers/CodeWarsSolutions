using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
/// The sum of these multiples is 23.
//Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. 
/// </summary>

namespace SumOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Solution(x);

            static int Solution(int value)
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < value; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        numbers.Add(i);

                    }
                }
                return numbers.Sum();
                
            }
        }
    }
}
