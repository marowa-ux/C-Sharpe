using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    internal class Program
    {
        // Structure to hold address details
        public struct Address
        {
            public string Street;
            public string City;
            public string State;
            public int ZipCode;

            // Constructor for the Address structure
            public Address(string street, string city, string state, int zipCode)
            {
                Street = street;
                City = city;
                State = state;
                ZipCode = zipCode;
            }

            // Method to display address details
            public void DisplayAddress()
            {
                Console.WriteLine("Address Details:");
                Console.WriteLine("Street: " + Street);
                Console.WriteLine("City: " + City);
                Console.WriteLine("State: " + State);
                Console.WriteLine("Zip Code: " + ZipCode);
            }
        }

        // Class to represent a person
        public class Person
        {
            public string Name;
            public int Age;
            public Address AddressDetails; // Structure instance

            // Constructor for the Person class
            public Person(string name, int age, Address address)
            {
                Name = name;
                Age = age;
                AddressDetails = address;
            }

            // Method to display person details
            public void DisplayPersonDetails()
            {
                Console.WriteLine("Person Details:");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                AddressDetails.DisplayAddress(); // Calling method from Address structure
            }
        }

        static void Main(string[] args)
        {
            // Creating an Address structure instance
            Address address = new Address("123 Elm Street", "Springfield", "IL", 62704);

            // Creating a Person class instance and passing the Address structure
            Person person = new Person("John Doe", 30, address);

            // Displaying the details
            person.DisplayPersonDetails();
        }
    }
}
