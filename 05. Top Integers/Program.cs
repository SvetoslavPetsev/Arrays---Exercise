using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            while (inputArray.Length >= 1)
            {

                int max = int.MinValue;
                int strong = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] >= max)
                    {
                        max = inputArray[i];
                        strong = i;
                    }
                }
                Console.Write(max + " ");
                int[] rev = new int[inputArray.Length - (strong + 1)];
                for (int k = 0; k < rev.Length; k++)
                {
                    rev[k] = inputArray[++strong];
                }
                inputArray = rev;
            }
        }
    }
}
