using System;
namespace SurajLabWork
{
    internal class _15Bthrow
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateAge(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("\nLab No: 15b");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }

        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Age must be 18 or above.");
            }
            else
            {
                Console.WriteLine("Age is valid.");
            }
        }
    }

}

