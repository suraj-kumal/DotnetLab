using System;
namespace SurajLabWork
{
    public class Pair<T>
    {
        // Generic fields
        private T first;
        private T second;

        // Constructor
        public Pair(T first, T second)
        {
            this.first = first;
            this.second = second;
        }

        // Generic method to swap the values of the pair
        public void Swap()
        {
            T temp = first;
            first = second;
            second = temp;
        }

        // Method to display the pair
        public void Display()
        {
            Console.WriteLine($"Pair: ({first}, {second})");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Pair of integers
            Pair<int> intPair = new Pair<int>(10, 20);
            Console.WriteLine("Before Swap:");
            intPair.Display();

            // Swapping the values
            intPair.Swap();
            Console.WriteLine("After Swap:");
            intPair.Display();

            // Creating a Pair of strings
            Pair<string> stringPair = new Pair<string>("Hello", "World");
            Console.WriteLine("Before Swap:");
            stringPair.Display();

            // Swapping the values
            stringPair.Swap();
            Console.WriteLine("After Swap:");
            stringPair.Display();

            // Creating a Pair of doubles
            Pair<double> doublePair = new Pair<double>(3.14, 6.28);
            Console.WriteLine("Before Swap:");
            doublePair.Display();

            // Swapping the values
            doublePair.Swap();
            Console.WriteLine("After Swap:");
            doublePair.Display();

            Console.ReadLine();
            Console.WriteLine("\nLab No: 11");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

