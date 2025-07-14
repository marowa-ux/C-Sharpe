using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing a string
            string originalString = " Hello, World! Welcome to C# programming. ";
            Console.WriteLine("Original String: " + originalString);

            // 1. Trim - Removes whitespace from the beginning and end
            string trimmedString = originalString.Trim();
            Console.WriteLine("Trimmed String: " + trimmedString);

            // 2. ToUpper - Converts the string to uppercase
            string upperCaseString = trimmedString.ToUpper();
            Console.WriteLine("Uppercase String: " + upperCaseString);

            // 3. ToLower - Converts the string to lowercase
            string lowerCaseString = trimmedString.ToLower();
            Console.WriteLine("Lowercase String: " + lowerCaseString);

            // 4. Contains - Checks if a substring is present
            bool containsWord = trimmedString.Contains("Welcome");
            Console.WriteLine("Contains 'Welcome': " + containsWord);

            // 5. Replace - Replaces a substring with another string
            string replacedString = trimmedString.Replace("C#", "CSharp");
            Console.WriteLine("Replaced String: " + replacedString);

            // 6. Substring - Extracts a part of the string
            string substring = trimmedString.Substring(7, 5); // Starting from index 7, length 5
            Console.WriteLine("Substring (7, 5): " + substring);

            // 7. Split - Splits the string into an array based on a delimiter
            string[] words = trimmedString.Split(' ');
            Console.WriteLine("Words in the string:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // 8. Length - Returns the length of the string
            int length = substring.Length;
            Console.WriteLine("Length of the trimmed string: " + length);

            // 9. IndexOf - Finds the position of a substring
            int index = trimmedString.IndexOf("World");
            Console.WriteLine("Index of 'World': " + index);

            
        }
    }
}
