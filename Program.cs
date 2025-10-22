using System;
namespace Ac06Implementacio
{
    // Exercise 5
    // PRECONDITION: The user is prompted to input three real numbers.
    public class Program
    {
        public static void Main()
        {
            const string MsgInputFirstNumber = "Enter the first number: ";
            const string MsgInputSecondNumber = "Enter the second number: ";
            const string MsgInputThirdNumber = "Enter the third number: ";
            const string MsgError = "Error in format.";
            const string MsgOutput = "The average is: ";

            // Variables
            float average;
            double num1, num2, num3;
            bool isDouble;

            // Input and data validation
            Console.WriteLine(MsgInputFirstNumber);
            isDouble = Double.TryParse(Console.ReadLine(), out num1);
            if (isDouble) 
            {
                Console.WriteLine(MsgInputSecondNumber);
                isDouble = Double.TryParse(Console.ReadLine(), out num2);
                if (isDouble) 
                {
                    Console.WriteLine(MsgInputThirdNumber);
                    isDouble = Double.TryParse(Console.ReadLine(), out num3);
                    if (isDouble) 
                    {
                        average = (float)(num1 + num2 + num3) / 3f;
                        // Output
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
