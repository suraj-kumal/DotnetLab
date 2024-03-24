using System;
namespace SurajLabWork
{
    abstract class JDMCar
    {
        public abstract void Describe();
    }
    interface IModifiable
    {
        void Modify(string modification);
    }
    interface ITunable
    {
        void Tune(int horsepowerIncrease);
    }

    class ToyotaSupra : JDMCar, IModifiable, ITunable
    {
        private string modelName;
        private int horsepower;

        // Constructor
        public ToyotaSupra(string modelName, int initialHorsepower)
        {
            this.modelName = modelName;
            this.horsepower = initialHorsepower;
        }

        public override void Describe()
        {
            Console.WriteLine($"Model: {modelName}, Horsepower: {horsepower}hp");
        }
        public void Modify(string modification)
        {
            Console.WriteLine($"Adding modification: {modification}");
        }

        // Method from ITunable interface
        public void Tune(int horsepowerIncrease)
        {
            this.horsepower += horsepowerIncrease;
            Console.WriteLine($"Tuning completed. New horsepower: {horsepower}hp");
        }
    }

    internal class _AbstractInterface
    {
        static void Main(string[] args)
        {
            // Creating an instance of Toyota Supra
            ToyotaSupra supra = new ToyotaSupra("Supra MK5", 340);

            // Describing the car
            Console.WriteLine("Initial Details:");
            supra.Describe();

            // Modifying the car
            supra.Modify("Exhaust system upgrade");

            // Tuning the car
            supra.Tune(50);
            Console.WriteLine("\nLab No: 7");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}
