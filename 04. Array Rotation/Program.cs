using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int keyNumber = int.Parse(Console.ReadLine());
            int index = 0;
            int[] rotArray = new int[numbers.Length];
            if (keyNumber > numbers.Length)
            {
                keyNumber = Math.Abs(keyNumber - numbers.Length);
            }
       
            for (int i = keyNumber; i < numbers.Length; i++)
            {
                rotArray[index] = numbers[i];
                index++;
            }
            for (int i = 0; i < keyNumber; i++)
            {
                rotArray[index] = numbers[i];
                index++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(rotArray[i] + " ");
            }
        }
    }
}
