using System;
using System.Linq;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            for (int i = 0; i < train.Length; i++)
            {
                
                    train[i] = int.Parse(Console.ReadLine());
               // Console.WriteLine(string.Join(" ", train));
            }

            Console.WriteLine(train.Sum()); //Sum arrays
        }
    }
}
