using System;
namespace SurajLabWork
{
    internal class _16ABuiltInAttr
    {
        [Obsolete("This method is deprecated. Use NewMethod instead.")]
        static void OldMethod()
        {
            Console.WriteLine("Old method is called.");
        }

        static void NewMethod()
        {
            Console.WriteLine("New method is called.");
        }

        [Obsolete]
        static void Main(string[] args)
        {
            // Using built-in Obsolete attribute
            OldMethod();

            // Call to OldMethod will generate a compiler warning
            // suggesting to use NewMethod instead
            NewMethod();
            Console.WriteLine("\nLab No: 16a");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

