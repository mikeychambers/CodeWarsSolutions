using System;

namespace FindNeedle
{
    class Program
    {
        static void Main(string[] args)
        {
             static string FindNeedle(object[] haystack)
            {
                int index = 0;

                foreach (var place in haystack)
                {

                    index++;
                    if (place.ToString() == "needle")
                    {
                        break;
                    }
                }
                return "needle found at position " + index.ToString();
            }
        }
    }
}
