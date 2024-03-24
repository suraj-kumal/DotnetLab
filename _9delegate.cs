using System;
namespace SurajLabWork
{
    delegate void Message(string msg);
    internal class _9delegate
    {
        public static void Main(string[] args)
        {
            Message myMessage = new Message(Display);
            myMessage.Invoke("Hello");
            static void Display(string msg)
            {
                Console.WriteLine(msg);
            }
            Console.WriteLine("\nLab No: 9a");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }
}