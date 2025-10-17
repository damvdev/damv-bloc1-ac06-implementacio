using System;

namespace Ac06Implementacio {
    // Exercise 2
    // PRECONDITION: The user is prompted to input a temperature in Celsius.
    public class Program {
        public static void Main()
        {
            // Constants
            const float KelvinOffset = 273.15f;
            const string MsgInput = "Enter temperature in Celsius:";
            const string MsgError = "Error in format";
            const string MsgResult = "Temperature in Kelvin:";

            // Variables
            float kelvin;
            double celsius;
            bool isInt;

            // Input and data validation
            Console.WriteLine(MsgInput);
            isInt = Double.TryParse(Console.ReadLine(), out celsius);
           
            if (isInt)
            {
                kelvin = (float) celsius + KelvinOffset;
                Console.WriteLine(MsgResult + " " + kelvin);
   
            }
            else
            {
                Console.WriteLine(MsgError);
            }
        }
    }
    // POSTCONDITION: 'kelvin' contains the converted temperature, and it is displayed.
}
