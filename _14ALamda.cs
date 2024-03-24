using System;
namespace SurajLabWork
{
    internal class _14ALamda
    {
        static void Main(string[] args)
        {
            // Lambda expression to square a number
            Func<int, int> square = x => x * x;

            // Using lambda expression to calculate square of a number
            int result = square(5);
            Console.WriteLine("Square of 5: " + result);
            Console.WriteLine("\nLab No: 14");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }


}
