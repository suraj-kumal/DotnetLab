using System;
namespace SurajLabWork
{
    internal class _15ATryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                // Potential exception-causing code
                int result = Divide(10, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
            Console.WriteLine("\nLab No: 15a");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }

        static int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }


}
