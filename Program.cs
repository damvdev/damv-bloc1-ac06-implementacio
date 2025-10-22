using System;
namespace Ac06Implementacio
{
    // Exercise 4
    // PRECONDITION: The user is prompted to input an amount in euros.
    public class Program
    {
        public static void Main()
        {
            // Change the ExchangeRate constant to use the 'M' suffix for decimal literals
            const decimal ExchangeRate = 1.12M;
            const string MsgInput = "Enter amount in euros: ";
            const string MsgError = "Error in format.";
            const string MsgOutput = "Amount in dollars: ";

            // Variables
            decimal euros, dollars;
            bool isDecimal;

            // Input and data validation
            Console.WriteLine(MsgInput);
            isDecimal = Decimal.TryParse(Console.ReadLine(), out euros);

            if (isDecimal)
            {
                dollars = euros * ExchangeRate;
                Console.WriteLine(MsgOutput + dollars);
            }
            else
            {
                Console.WriteLine(MsgError);
            }
        }
    }
    // POSTCONDITION: 'dollars' contains the converted amount, and it is displayed.
}