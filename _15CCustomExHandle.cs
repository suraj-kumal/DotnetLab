using System;
namespace SurajLabWork
{
    internal class _15CCustomExHandle
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateNumber(-5);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("\nLab No: 15c");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }

        static void ValidateNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("Number cannot be negative.");
            }
            else
            {
                Console.WriteLine("Number is valid.");
            }
        }
    }

    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }

}

