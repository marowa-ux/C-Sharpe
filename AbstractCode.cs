using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCodeExample
{ 

     // Abstract class
 abstract class Shape
{
    // Abstract method
    public abstract double CalculateArea();
}

// Derived class for Circle
class Circle : Shape
{
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementation of abstract method
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class for Rectangle
class Rectangle : Shape
{
    private double length;
    private double width;

    // Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementation of abstract method
    public override double CalculateArea()
    {
        return length * width;
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of derived classes
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            // Display the areas
            Console.WriteLine("The area of the circle is: " + circle.CalculateArea());
            Console.WriteLine("The area of the rectangle is: " + rectangle.CalculateArea());

            Console.ReadLine();
        }
    }
}
