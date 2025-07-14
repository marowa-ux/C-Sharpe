using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastImEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Casting (automatic)
            int numInt = 100;
            double numDouble = numInt;  // int to double

            Console.WriteLine("Implicit Type Casting:");
            Console.WriteLine("Integer value: " + numInt);
            Console.WriteLine("Converted to double: " + numDouble);

            // Explicit Type Casting (manual)
            double pi = 3.14159;
            int roundedPi = (int)pi;  // double to int, truncates the decimal part

            Console.WriteLine("\nExplicit Type Casting:");
            Console.WriteLine("Double value: " + pi);
            Console.WriteLine("Converted to integer (rounded down): " + roundedPi);

            // Explicit Type Casting with Parse and Convert methods
            string strNumber = "123";
            int parsedNumber = int.Parse(strNumber);  // string to int
            double convertedNumber = Convert.ToDouble(strNumber);  // string to double

            Console.WriteLine("\nExplicit Type Casting using Parse and Convert:");
            Console.WriteLine("String value: " + strNumber);
            Console.WriteLine("Converted to integer using Parse: " + parsedNumber);
            Console.WriteLine("Converted to double using Convert: " + convertedNumber);
        
    }
    }
}
