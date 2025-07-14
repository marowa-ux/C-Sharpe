using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllOperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 5;
            int result;

            result = a + b;
            Console.WriteLine("Addition: " + result);
            

            result = a - b;
            Console.WriteLine("Subtraction: " + result);

            result = a * b;
            Console.WriteLine("Multiplication: " + result);

            result = a / b;
            Console.WriteLine("Division: " + result);

            result = a % b;
            Console.WriteLine("Modulus: " + result);

            // Assignment Operators

            Console.WriteLine(" ");
            result = a;
            Console.WriteLine("Assigned result = a: " + result);

            result += b;
            Console.WriteLine("result += b: " + result);

            result -= b;
            Console.WriteLine("result -= b: " + result);

            result *= b;
            Console.WriteLine("result *= b: " + result);

            result /= b;
            Console.WriteLine("result /= b: " + result);

            result %= b;
            Console.WriteLine("result %= b: " + result);

            Console.WriteLine(" ");

            // Comparison Operators
            bool isEqual = (a == b);
            Console.WriteLine("a == b: " + isEqual);

            bool isNotEqual = (a != b);
            Console.WriteLine("a != b: " + isNotEqual);

            bool isGreater = (a > b);
            Console.WriteLine("a > b: " + isGreater);

            bool isLess = (a < b);
            Console.WriteLine("a < b: " + isLess);

            bool isGreaterOrEqual = (a >= b);
            Console.WriteLine("a >= b: " + isGreaterOrEqual);

            bool isLessOrEqual = (a <= b);
            Console.WriteLine("a <= b: " + isLessOrEqual);

            // Logical Operators
            Console.WriteLine(" ");

            bool x = true;
            bool y = false;

            bool andResult = x && y;
            Console.WriteLine("x && y: " + andResult);

            bool orResult = x || y;
            Console.WriteLine("x || y: " + orResult);

            bool notResult = !x;
            Console.WriteLine("!x: " + notResult);
        }
    }
}
