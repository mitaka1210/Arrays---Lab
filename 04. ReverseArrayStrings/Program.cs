using System;
using System.Linq;

namespace _04._ReverseArrayStrings
{
    class Program
    {
        public static void Main(string[] args)
        {

            string name = Console.ReadLine();
            string[] text = name.Split();

            for (int i = 0; i < text.Length; i++)
            {
                
            }
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
