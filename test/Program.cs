using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();
            int even = 0;

            // Loop to find even
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                    even += n[i];
               
            }

            Console.WriteLine(even);

            
        }
    }
}
