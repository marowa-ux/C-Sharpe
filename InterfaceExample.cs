using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    //Interface definition
    interface IShape
    {
        double CalculateArea();
    }

    // Class implementing IShape for Circle
    class Circle : IShape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementation of CalculateArea
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Class implementing IShape for Rectangle
    class Rectangle : IShape
    {
        private double length;
        private double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Implementation of CalculateArea
        public double CalculateArea()
        {
            return length * width;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of classes implementing IShape
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);

            // Display the areas
            Console.WriteLine("The area of the circle is: " + circle.CalculateArea());
            Console.WriteLine("The area of the rectangle is: " + rectangle.CalculateArea());

            Console.ReadLine();
        }
    }
}
