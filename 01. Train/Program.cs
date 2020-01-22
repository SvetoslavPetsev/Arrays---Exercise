using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] stops = new int[stopNumber];
            for (int i = 0; i < stopNumber; i++)
            {
                stops[i] = int.Parse(Console.ReadLine());
                sum += stops[i];
            }
            for (int i = 0; i < stops.Length; i++)
            {
                Console.Write(stops[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
