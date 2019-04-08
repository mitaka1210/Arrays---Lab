using System;
using System.Linq;


namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0.9 1.5 2.4 2.5 3.14
            double[] n = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"{n[i]} {"=>"} { Math.Round(n[i], MidpointRounding.AwayFromZero)}");
                //Console.Write(Math.Round(n[i] , MidpointRounding.AwayFromZero));
            }
        }
    }
}
