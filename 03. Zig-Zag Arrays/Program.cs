using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberLines];
            int[] secondArray = new int[numberLines];
            int indexF = 0;
            int indexS = 0;

            for (int i = 1; i <= numberLines; i++)
            {
                int[] inputArray = Console
                    .ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)
                {
                    firstArray[indexF] = inputArray[0];
                    secondArray[indexS] = inputArray[1];   
                }
                else
                {
                    firstArray[indexF] = inputArray[1];
                    secondArray[indexS] = inputArray[0];
                }
                indexF++;
                indexS++;
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
        }
    }
}
