using System;

namespace SurajLabWork
{
    class Student
    {
        public string? Name { get; set; }

    }
    class Rectangle
    {
        public int Width { get; }
        public int Height { get; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
    internal class _1Property
    {
        public static void Main()
        {
            Student student = new Student();
            student.Name = "Suraj";
            Console.WriteLine("Auto Property");
            Console.WriteLine("Name :" + student.Name);


            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("\nRead-only Property");
            Console.WriteLine("Width:" + rectangle.Width);
            Console.WriteLine("Height : " + rectangle.Height);
            //Cannot modify read-only property
            //rectangle.Width = 15; //this line will give a compilation error
            Console.WriteLine("\nLab No: 2");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }

    }
}