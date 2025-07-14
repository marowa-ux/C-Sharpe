using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureWithPropertyExample
{
    internal class Program
    {
        public struct Address
        {
            private string street;
            private string city;
            private string state;
            private int zipCode;

            // Properties to access private fields
            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string State
            {
                get { return state; }
                set { state = value; }
            }

            public int ZipCode
            {
                get { return zipCode; }
                set { zipCode = value; }
            }

            // Constructor for the Address structure
            public Address(string street, string city, string state, int zipCode)
            {
                this.street = street;
                this.city = city;
                this.state = state;
                this.zipCode = zipCode;
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
            private string name;
            private int age;
            private Address addressDetails;

            // Properties to access private fields
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public Address AddressDetails
            {
                get { return addressDetails; }
                set { addressDetails = value; }
            }

            // Constructor for the Person class
            public Person(string name, int age, Address address)
            {
                this.name = name;
                this.age = age;
                this.addressDetails = address;
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
