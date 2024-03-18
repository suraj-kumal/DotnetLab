using System;
// using System.Runtime.CompilerServices;

namespace SurajLabWork
{
    class MyClass
    {
        private static int x;
        private int a;
        private double b;

        //private constructor
        private MyClass(int a)
        {
            this.a = a;
            Console.WriteLine($"value of a : {a} using private constructor");

        }

        //static constructor
        static MyClass()
        {
            x = 10;
            Console.WriteLine($"value of x : {x} using static constructors");
        }

        //default constructor
        public MyClass()
        {
            a = 3;
            b = 4.3;
            Console.WriteLine($"value of a : {a} adn b : {b} using default constructor");

        }

        //parameterized constructor
        public MyClass(int a, double b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine($"value of a : {a} and b : {b} using parameterized constructor");
        }

        //copy constructor
        public MyClass(MyClass copy)
        {
            this.a = copy.a;
            this.b = copy.b;
            Console.WriteLine($"value of a : {this.a} and b : {this.b} using copy constructor");
        }
    }

    internal class _1Constructors
    {
        public static void Main()
        {
            MyClass X1 = new MyClass();
            MyClass myClass = new MyClass(3, 8.9);
            MyClass C1 = new MyClass(myClass);
            // Since the private constructor is not accessible outside the class,
            // this will cause a compilation error
            // MyClass C2 = new MyClass(5);
            Console.WriteLine("Lab No: 1");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");

        }
    }
}