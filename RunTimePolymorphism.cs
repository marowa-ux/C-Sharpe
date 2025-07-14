using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePolymorphismEx1
{
    internal class Program
    {
        // Base class
        public class Animal
        {
            // Virtual method to allow overriding
            public virtual void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        // Derived class: Dog
        public class Dog : Animal
        {
            // Override the Speak method
            public override void Speak()
            {
                Console.WriteLine("The dog barks: Woof! Woof!");
            }
        }

        // Derived class: Cat
        public class Cat : Animal
        {
            // Override the Speak method
            public override void Speak()
            {
                Console.WriteLine("The cat meows: Meow!");
            }
        }
        static void Main(string[] args)
        {
            // Using base class reference
            Animal myAnimal = new Animal();
            myAnimal.Speak(); // Outputs: The animal makes a sound.

            // Dog object
            Animal myDog = new Dog();
            myDog.Speak(); // Outputs: The dog barks: Woof! Woof!

            // Cat object
            Animal myCat = new Cat();
            myCat.Speak(); // Outputs: The cat meows: Meow!

        }
    }
}
