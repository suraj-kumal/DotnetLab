using System;
using System.Reflection;
namespace SurajLabWork
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    class _16BCustomAttr
    {
        [Author("Suraj Kumal")]
        public static void MyMethod()
        {
            Console.WriteLine("Method authored by Suraj Kumal.");
        }

        static void Main(string[] args)
        {
            // Retrieving custom attribute information
            var methodInfo = typeof(_16BCustomAttr).GetMethod("MyMethod");
            var attribute = Attribute.GetCustomAttribute(methodInfo!, typeof(AuthorAttribute)) as AuthorAttribute;

            // Displaying author information
            if (attribute != null)
            {
                Console.WriteLine("Author of MyMethod: " + attribute.Name);
            }
            else
            {
                Console.WriteLine("Author attribute not found.");
            }
            Console.WriteLine("\nLab No: 16b");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

