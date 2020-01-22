using System;
using System.Linq;

namespace _06._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rightSum = input.Sum();
            int leftSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                rightSum -= input[i];
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += input[i];
            }
            Console.WriteLine("no");
        }
    }
}
