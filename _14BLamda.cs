using System;
using System.Linq;
namespace SurajLabWork
{
    internal class _14BLamda
    {
        static void Main(string[] args)
        {
            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query using lambda expression to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            // Displaying even numbers
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nLab No: 14");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

