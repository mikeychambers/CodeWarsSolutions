using System;
/// <summary>
/// Given two numbers and an arithmetic operator (the name of it, as a string),
/// return the result of the two numbers having that operator used on them.
//a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.
///The four operators are "add", "subtract", "divide", "multiply". 
/// </summary>
namespace ArithmeticFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            static double Arithmetic(double a, double b, string op)
            {
                double x = 0;
                switch (op)
                {
                    case "add":
                        x = a + b;
                        break;
                    case "subtract":
                        x = a - b;
                        break;
                    case "multiply":
                        x = a * b;
                        break;
                    case "divide":
                        x = a / b;
                        break;
                }
                return x;
            }
        }
    }
}
