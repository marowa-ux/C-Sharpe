using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        public class Calculator
        {
            // Method to calculate the area of a square
            public int CalculateArea(int side)
            {
                return side * side;
            }

            // Method to calculate the area of a rectangle
            public int CalculateArea(int length, int width)
            {
                return length * width;
            }

            // Method to calculate the area of a circle
            public double CalculateArea(double radius)
            {
                return Math.PI * radius * radius;
            }
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Calculate area of a square
            int squareArea = calc.CalculateArea(5);
            Console.WriteLine("Area of Square: " + squareArea);

            // Calculate area of a rectangle
            int rectangleArea = calc.CalculateArea(5, 10);
            Console.WriteLine("Area of Rectangle: " + rectangleArea);

            // Calculate area of a circle
            double circleArea = calc.CalculateArea(7.5);
            Console.WriteLine("Area of Circle: " + circleArea);

        }
    }
}
