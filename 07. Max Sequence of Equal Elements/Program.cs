using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
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
           
            int counter = 1;
            int maxEqual = 1;
            int element = 0;
            bool allEqual = false;
            int a = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (a == inputArray[i])
                {
                    allEqual = true;
                }
                else
                {
                    allEqual = false;
                    break;
                }
            }
            if (allEqual == true)
            {
                maxEqual = inputArray.Length;
                element = inputArray[0];
            }
            else
            {
                for (int i = 0; i < inputArray.Length - 1; i++)
                {

                    if (inputArray[i] == inputArray[i + 1])
                    {
                        counter++;
                        if (counter > maxEqual)
                        {
                            element = inputArray[i];
                            maxEqual = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }
            for (int i = 0; i < maxEqual; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
