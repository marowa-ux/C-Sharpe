using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePropertyEx1
{      // Base class: Vehicle
    public class Vehicle
    {
        private int _speed; // Private field for Speed
        private string _color; // Private field for Color

        // Property for Speed
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value >= 0) // Ensure non-negative speed
                    _speed = value;
                else
                    Console.WriteLine("Speed cannot be negative.");
            }
        }

        // Property for Color
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // Method to display vehicle details
        public void DisplayDetails()
        {
            Console.WriteLine($"Speed: {Speed} km/h, Color: {Color}");
        }
    }

    // Derived class: Car
    public class Car : Vehicle
    {
        private int _numberOfDoors; // Private field for NumberOfDoors

        // Property for NumberOfDoors
        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
            set
            {
                if (value > 0) // Ensure at least one door
                    _numberOfDoors = value;
                else
                    Console.WriteLine("Number of doors must be positive.");
            }
        }

        // Method to display car details
        public void DisplayCarDetails()
        {
            DisplayDetails(); // Call base class method
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Derived class: Bike
    public class Bike : Vehicle
    {
        private bool _hasCarrier; // Private field for HasCarrier

        // Property for HasCarrier
        public bool HasCarrier
        {
            get { return _hasCarrier; }
            set { _hasCarrier = value; }
        }

        // Method to display bike details
        public void DisplayBikeDetails()
        {
            DisplayDetails(); // Call base class method
            Console.WriteLine($"Has Carrier: {(HasCarrier ? "Yes" : "No")}");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // Create Car object
            Car myCar = new Car();
            myCar.Speed = 180;
            myCar.Color = "Red";
            myCar.NumberOfDoors = 4;

            Console.WriteLine("Car Details:");
            myCar.DisplayCarDetails();

            // Create Bike object
            Bike myBike = new Bike();
            myBike.Speed = 60;
            myBike.Color = "Blue";
            myBike.HasCarrier = true;

            Console.WriteLine("\nBike Details:");
            myBike.DisplayBikeDetails();
        }
    }
}
