using System;
using System.Collections.Generic;

/// <summary>
/// Square every digit then concatanate them
/// </summary>
namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareDigits(9119);

             static int SquareDigits(int n)
             {
                char[] charArray = n.ToString().ToCharArray();
                List<string> sqList = new List<string>();
                int numberToSquare;
                int squaredNumber;
                
                foreach (char x in charArray)
                {
                    numberToSquare = Int32.Parse(x.ToString());
                    squaredNumber = numberToSquare * numberToSquare;
                    sqList.Add(squaredNumber.ToString());
                    
                }

                string conCat = string.Join("", sqList);
                int answer = Int32.Parse(conCat);
               return answer;
            }

            
           
           
        }
    }
}
