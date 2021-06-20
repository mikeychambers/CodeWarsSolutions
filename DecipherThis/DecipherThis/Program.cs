using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/// <summary>
/// The deciphering rules are.
/// For each word in the passed string switch second and last letter.
/// The first letter is replaced by its character code.
/// </summary>



//Have a List of ascii chars join asciis back on to strings
namespace DecipherThis
{
    class Program
    {
        static void Main(string[] args)
        {
            string convertToChar = "65 119esi 111dl 111lw 108dvei 105n 97n 111ka";


            static string DecipherThis(string s)
            {
                List<string> splitString = new List<string>(s.Split());
                List<string> decipheredString = new List<string>();
                List<string> stringComplete = new List<string>();

                foreach (string x in splitString)
                {
                    if (x == "")
                    {
                        stringComplete.Add(x);
                    }

                    else
                    {
                        string getIntsFromString = Regex.Replace(x, "[^0-9.]", "");
                        int convertToInt = Int32.Parse(getIntsFromString);
                        string toAsciiCharacter = Convert.ToChar(convertToInt).ToString();
                        string asciiReplacedString = x.Replace(getIntsFromString, toAsciiCharacter);
                        decipheredString.Add(asciiReplacedString);
                    }

                }

                foreach (string x in decipheredString)
                {
                    int lastElement = x.Length - 1;
                    if (x.Length <= 1)
                    {
                        stringComplete.Add(x);
                    }

                    else
                    {
                        char[] array = x.ToCharArray();
                        char temp = array[1];
                        array[1] = array[lastElement];
                        array[lastElement] = temp;
                        string e = new string(array);
                        stringComplete.Add(e);
                    }

                }

                string decString;
                return decString = String.Join(" ", stringComplete.ToArray());
            }
        }
    }
}
