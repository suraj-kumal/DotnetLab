using System;

namespace SurajLabWork
{
    class _3JaggedArray
    {
        public static void Main()
        {
            int[][] JaggedArray = new int[3][];
            JaggedArray[0] = new int[] { 1, 2, 3 };
            JaggedArray[1] = new int[] { 4, 5 };
            JaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < JaggedArray.Length; i++)
            {
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    Console.WriteLine(JaggedArray[i][j] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nLab No: 3");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
    }
}