using System;
namespace SurajLabWork
{
    class _9eAction
    {
        static void Main(string[] args)
        {
            Action<string> printMessage = (message) => Console.WriteLine("Action Delegate: " + message);
            printMessage("Hello");
            Console.WriteLine("\nLab No: 9e");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

