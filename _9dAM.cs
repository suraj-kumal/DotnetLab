using System;

namespace SurajLabWork
{
    internal class _9dAM
    {
        delegate void MyDelegate(string message);

        public static void Main()
        {
            MyDelegate myDelegate = delegate (string message)
            {
                Console.WriteLine("Anonymous Method: " + message);
            };
            myDelegate("Hello");
            Console.WriteLine("\nLab No: 9d");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }
}
