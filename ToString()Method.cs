using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString__MethodExample
{
    internal class Program
    {
        // Structure to represent a date
        public struct DateOfBirth
        {
            private int day;
            private int month;
            private int year;

            // Properties to access private fields
            public int Day
            {
                get { return day; }
                set { day = value; }
            }

            public int Month
            {
                get { return month; }
                set { month = value; }
            }

            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            // Constructor with parameter names different from field names
            public DateOfBirth(int inputDay, int inputMonth, int inputYear)
            {
                day = inputDay;   // No need for 'this'
                month = inputMonth;
                year = inputYear;
            }

            // Simplified ToString() using DateTime
            public override string ToString()
            {
                return new DateTime(Year, Month, Day).ToString("dd/MM/yyyy");
            }
        }

        // Class to represent a person
        public class Person
        {
            private string name;
            private DateOfBirth dateOfBirth;

            // Properties to access private fields
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public DateOfBirth DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            // Constructor with parameter names different from field names
            public Person(string inputName, DateOfBirth inputDateOfBirth)
            {
                name = inputName; // No need for 'this'
                dateOfBirth = inputDateOfBirth;
            }

            // Method to display person details
            public void DisplayDetails()
            {
                Console.WriteLine("Person Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Date of Birth: {DateOfBirth}"); // Calls DateOfBirth.ToString()
            }
        }

        static void Main(string[] args)
        {

            // Creating a DateOfBirth structure instance
            DateOfBirth dob = new DateOfBirth(15, 8, 1995);

            // Creating a Person class instance
            Person person = new Person("Alice", dob);

            // Displaying the details
            person.DisplayDetails();
        }
    }
}
