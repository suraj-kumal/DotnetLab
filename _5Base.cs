using System;

namespace SurajLabWork
{
    // Base class
    class Vehicle
    {
        protected string manufacturer;
        protected int year;

        // Base class constructor
        public Vehicle(string manufacturer, int year){
            this.manufacturer = manufacturer;
            this.year = year;
            Console.WriteLine("Vehicle constructor called.");
        }

        // Base class method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Manufacturer: {manufacturer}, Year: {year}");
        }
    }

    // Derived class
    class Car : Vehicle
    {
        private string model;

        // Derived class constructor
        public Car(string manufacturer, int year, string model) : base(manufacturer, year)
        {
            this.model = model;
            Console.WriteLine("Car constructor called.");
        }

        // Method overriding
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Calling base class method
            Console.WriteLine($"Model: {model}");
        }
    }

    internal class _5Base
    {
        static void Main(string[] args)
        {
            // Create an instance of the derived class
            Car myCar = new Car("Toyota", 2022, "Corolla");

            myCar.DisplayInfo();
             Console.WriteLine("\nLab No: 5");
             Console.WriteLine("Name : Suraj Kumal");
             Console.WriteLine("Roll no : 32");
        }
    }
} 
