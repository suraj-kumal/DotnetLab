using System;
namespace SurajLabWork
{
    class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent's Display method");
        }
    }

    class Child : Parent
    {
        public new void Display() // Method hiding
        {
            Console.WriteLine("Child's Display method");
        }
    }

    internal class _6ahiding
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Display(); // Calls Parent's Display method

            Child child = new Child();
            child.Display(); // Calls Child's Display method

            Parent childAsParent = new Child();
            childAsParent.Display(); // Calls Parent's Display method
            Console.WriteLine("\nLab No: 6a");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

