using System;

namespace Ac06Implementacio
{
    // Exercise 3
    // PRECONDITION: The user is prompted to input the width and height of a rectangle.
    public class Program
    {
        public static void Main()
        {
            // Constants
            const string MsgInputWidth = "Enter the width of the rectangle:";
            const string MsgInputHeight = "Enter the height of the rectangle:";
            const string MsgError = "Error in format";
            const string MsgResult = "The area of the rectangle is:";

            // Variables
            float area;
            double width, height;
            bool isInt;

            // Input and data validation
            Console.WriteLine(MsgInputWidth);
            isInt = Double.TryParse(Console.ReadLine(), out width);

            if (isInt)
            {
                Console.WriteLine(MsgInputHeight);
                isInt = Double.TryParse(Console.ReadLine(), out height);
                if (isInt)
                {
                    area = (float)(width * height);
                    Console.WriteLine(MsgResult + " " + area);
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
    // POSTCONDITION: 'area' contains the product of 'width' and 'height', and it is displayed.
}