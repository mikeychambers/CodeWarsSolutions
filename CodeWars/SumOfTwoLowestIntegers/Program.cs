using System;
using System.Linq;
/// <summary>
/// Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. 
/// No floats or non-positive integers will be passed.
/// </summary>
namespace SumOfTwoLowestIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 22, 19, 12, 8 };

            sumTwoSmallestNumbers(numbers);

            static int sumTwoSmallestNumbers(int[] numbers)
            {
                int[] orderedArray = numbers.OrderBy(i => i).ToArray();
                return orderedArray[0] + orderedArray[1];
            }
        }
    }
}
