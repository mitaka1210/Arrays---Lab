using System;
using System.Linq;


namespace _05._SumEvenNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                // int curentNumber = n[i];
                if (i % 2 == 0)
                {
                    sum += n[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int even = 0, odd = 0; 

//        // Loop to find even, odd sum 
//        for (int i = 0; i<arr.Length; i++) 
//        { 
//            if (i % 2 == 0) 
//                even += arr[i]; 
//            else
//                odd += arr[i]; 
//        } 

//        Console.WriteLine("Even index positions"
//                             + " sum: " + even); 

//        Console.WriteLine("Odd index positions "
//                               + "sum: " + odd); 
//    } 