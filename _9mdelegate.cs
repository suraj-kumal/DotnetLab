using System;
namespace SurajLabWork
{
    internal class _9mdelegate
    {
        delegate void MyDelegate(string message);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method2;

            myDelegate("Hello");
            Console.WriteLine("\nLab No: 9b");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }

        static void Method1(string message)
        {
            Console.WriteLine("Method 1: " + message);
        }

        static void Method2(string message)
        {
            Console.WriteLine("Method 2: " + message);
        }
    }

}

