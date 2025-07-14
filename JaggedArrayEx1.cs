using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a jagged array with three arrays inside it
            int[][] jaggedArray = new int[3][];

            // Initialize the jagged array
            jaggedArray[0] = new int[] { 1, 2, 3, 6 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Print the elements of the jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
