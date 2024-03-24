using System;
using System.Collections.Generic;
using System.Linq;
namespace SurajLabWork
{
    internal class _13LINQ
    {
        static void Main(string[] args)
        {
            // Creating a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using LINQ to filter even numbers from the list
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            // Displaying the filtered even numbers
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\nLab No: 13");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }


}
