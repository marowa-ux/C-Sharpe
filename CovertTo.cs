using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovertToExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert string to int
            string numberString = "123";
            int number = Convert.ToInt32(numberString);
            Console.WriteLine("String to Int: " + number);

            // Convert string to double
            string doubleString = "123.45";
            double doubleValue = Convert.ToDouble(doubleString);
            Console.WriteLine("String to Double: " + doubleValue);

            // Convert double to int
            double decimalNumber = 45.67;
            int intNumber = Convert.ToInt32(decimalNumber); // This will round the double
            Console.WriteLine("Double to Int: " + intNumber);

            // Convert bool to string
            bool boolValue = true;
            string boolString = Convert.ToString(boolValue);
            Console.WriteLine("Bool to String: " + boolString);

            // Convert string to bool
            string boolText = "true";
            bool parsedBool = Convert.ToBoolean(boolText);
            Console.WriteLine("String to Bool: " + parsedBool);

            // Convert DateTime to string
            DateTime date = DateTime.Now;
            string dateString = Convert.ToString(date);
            Console.WriteLine("DateTime to String: " + dateString);

            
        }
    }
}
