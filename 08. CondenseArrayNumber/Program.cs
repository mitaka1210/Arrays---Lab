﻿using System;
using System.Linq;

namespace _08._CondenseArrayNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            //Arrays-Exercise
            var counter = input.Length;
            while (counter > 1)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i] + input[i + 1];
                }
                counter--;
            }
            Console.WriteLine(input[0]);
        }
    }
}
