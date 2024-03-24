using System;
using System.Collections; // For non-generic collections
using System.Collections.Generic; // For generic collections
namespace SurajLabWork
{
    internal class _10GenericCNon
    {
        static void Main(string[] args)
        {

            ArrayList nonGenericList = new ArrayList();
            nonGenericList.Add(10);
            nonGenericList.Add("Hello");
            nonGenericList.Add(true);

            Console.WriteLine("Non-Generic Collection (ArrayList):");
            foreach (var item in nonGenericList)
            {
                Console.WriteLine(item);
            }

            List<int> genericList = new List<int>();
            genericList.Add(20);
            genericList.Add(30);
            genericList.Add(40);

            Console.WriteLine("\nGeneric Collection (List<int>):");
            foreach (var item in genericList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nLab No: 10");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }

}

