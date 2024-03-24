using System;
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}
public enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// c) Partial class
public partial class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

public partial class Person
{
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point(10, 20);
        point.Display();

        Day today = Day.Monday;
        Console.WriteLine($"Today is: {today}");

        Person person = new Person
        {
            FirstName = "Suraj",
            LastName = "Kumal",
            Age = 22
        };
        person.Display();
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine("\nLab No: 8");
        Console.WriteLine("Name : Suraj Kumal");
        Console.WriteLine("Roll no : 32");
    }
}
