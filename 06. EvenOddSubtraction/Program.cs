using System;
using System.Linq;


namespace _06._EvenOddSubtraction
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int even = 0;
            int odd = 0;
            int sum = 0;
          

            // Loop to find even, odd sum 
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                    even += n[i];
                else
                    odd += n[i];
            }
            sum = even - odd;
            Console.WriteLine(sum);
        }
    }
}
