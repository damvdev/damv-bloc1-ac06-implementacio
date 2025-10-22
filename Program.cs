using System;
namespace Ac06Implementacio
{
    // Exercise 5
    // PRECONDITION: The user is prompted to input three real numbers.
    public class Program
    {
        public static void Main()
        {
            // Constants
            const string MsgInputFirstNumber = "Enter the first number: ";
            const string MsgInputSecondNumber = "Enter the second number: ";
            const string MsgInputThirdNumber = "Enter the third number: ";

            const string MsgError = "Error in format.";
            const string MsgOutput = "The average is: ";

            // Variables
            float average;
            double numOne, numberTwo, numThree;
            bool isDouble;

            // Input and data validation
            Console.WriteLine(MsgInputFirstNumber);
            isDouble = Double.TryParse(Console.ReadLine(), out numOne);
            if (isDouble) 
            {
                Console.WriteLine(MsgInputSecondNumber);
                isDouble = Double.TryParse(Console.ReadLine(), out numberTwo);
                if (isDouble) 
                {
                    Console.WriteLine(MsgInputThirdNumber);
                    isDouble = Double.TryParse(Console.ReadLine(), out numThree);
                    if (isDouble) 
                    {
                        average = (float)(numOne + numberTwo + numThree) / 3f;
                        Console.WriteLine(MsgOutput + average);
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
            else 
            {
                Console.WriteLine(MsgError);
            }
        }
    }
    // POSTCONDITION: 'average' contains the arithmetic mean of the three numbers, and it is displayed.
}
