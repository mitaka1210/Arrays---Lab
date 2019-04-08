using System;
using System.Linq;

namespace _07._EqualArrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arrays1 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] arrays2 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();


            for (int i = 0; i < arrays1.Length; i++)
            {
                if (arrays1[i] != arrays2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }
            Console.WriteLine($"Arrays are identical. Sum: {arrays2.Sum()}");

        }
    }
}
