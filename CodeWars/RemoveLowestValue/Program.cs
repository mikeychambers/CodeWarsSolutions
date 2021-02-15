using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Given an array of integers, remove the smallest value. Do not mutate the original array/list.
///Don't change the order of the elements that are left.
/// </summary>
namespace RemoveLowestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveSmallest(new List<int>() { 1, 2, 3, 4, 5 });

            static List<int> RemoveSmallest(List<int> numbers)
            {
                numbers.Remove(numbers.Min());
                return numbers;

            }
        }
    }
}
