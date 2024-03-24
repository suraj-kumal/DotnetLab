using System;
using System.IO;
namespace SurajLabWork
{
    internal class _12File
    {
        static void Main(string[] args)
        {
            // Ask the user for a file name to write to
            Console.WriteLine("Enter the file name to write to:");
            string fileName = Console.ReadLine() + ".txt";

            // Prompt the user for input
            Console.WriteLine("Enter some text (press Enter to finish):");

            // Open the file for writing
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Read input from the user and write it to the file
                string input;
                while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
                {
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("Data has been written to the file.");
            Console.WriteLine("\nLab No: 12");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

