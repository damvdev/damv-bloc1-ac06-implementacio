using System;
namespace Ac06Implementacio
{
    // Exercise 1
    // PRECONDITION: The user is prompted to input two integers.
    public class Program
    {
        public static void Main()
        {
            // Constants
            const string MsgInputOne = "Enter the first integer:";
            const string MsgInputTwo = "Enter the second integer:";
            const string MsgError = "Error in format";
            const string MsgResult = "The sum is:";

            // Variables
            int numOne, numTwo, sum;
            bool isInt;

            // Input and data validation
            Console.WriteLine(MsgInputOne);
            isInt = Int32.TryParse(Console.ReadLine(), out numOne);

            if (isInt)
            {
                Console.WriteLine(MsgInputTwo);
                isInt = Int32.TryParse(Console.ReadLine(), out numTwo);
                if (isInt)
                {
                    sum = numOne + numTwo;
                    Console.WriteLine(MsgResult + " " + sum);
                }
                else
                {
                    Console.WriteLine(MsgError);
                }
            }
            else
            {
                Console.WriteLine(MsgError);
            }
        }
    }
    // POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is // displayed.
}