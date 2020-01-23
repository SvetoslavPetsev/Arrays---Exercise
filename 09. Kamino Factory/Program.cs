using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            int counterDnkTest = 0;
            int bestTestNumber = 0;
            int[] bestDnk = new int[range];
            int maxSum = 0;
            int maxSeq = 0;
            int indexBest = range - 1;

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                counterDnkTest++;
                int[] dnkInput = input
               .Split("!")
               .Select(int.Parse)
               .ToArray();

                int sumOnes = 0;
                int counterSeq = 0;
                int maxArraySeq = 0;
                int indexSeg = 0;
                bool check = false;

                for (int i = 0; i < dnkInput.Length; i++)
                {
                    if (dnkInput[i] == 1)
                    {
                        counterSeq++;
                        sumOnes += dnkInput[i];
                        if (counterSeq > maxArraySeq)
                        {
                            maxArraySeq = counterSeq;
                            indexSeg = i + 1 - counterSeq;
                        }
                        continue;
                    }
                    else
                    {
                        counterSeq = 0;
                    }                   
                }
                if (maxArraySeq > maxSeq)
                {
                    check = true;
                }
                else if (maxArraySeq == maxSeq)
                {
                    if (indexSeg < indexBest)
                    {
                        check = true;
                    }
                    else if (indexSeg == indexBest)
                    {
                        if (sumOnes > maxSum)
                        {
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    maxSeq = maxArraySeq;
                    indexBest = indexSeg;
                    maxSum = sumOnes;
                    bestDnk = dnkInput;
                    bestTestNumber = counterDnkTest;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestTestNumber} with sum: {maxSum}.");
            Console.WriteLine(string.Join(' ', bestDnk));
        }
    }
}
