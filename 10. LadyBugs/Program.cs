using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] startPlace = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();

            int[] bugsOnField = new int[sizeOfField];

            for (int i = 0; i < bugsOnField.Length; i++)
            {
                for (int j = 0; j < startPlace.Length; j++)
                {
                    if (Math.Abs(startPlace[j]) == i)
                    {
                        bugsOnField[i] = 1;
                        break;
                    }
                    else
                    {
                        bugsOnField[i] = 0;
                    }
                }
            }
            while (input != "end")
            {
                string[] command = input
                    .Split(" ")
                    .ToArray();
                int currentPosition = Convert.ToInt32(command[0]);
                string direction = command[1];
                int moveLenght = Convert.ToInt32(command[2]);

                if (bugsOnField[currentPosition] == 1 && moveLenght != 0)
                {
                    if (direction == "right")
                    {
                        int newRightPosition = currentPosition + moveLenght;
                        bugsOnField[currentPosition] = 0;
                        while (newRightPosition >= 0 && newRightPosition < bugsOnField.Length)
                        {
                            if (bugsOnField[newRightPosition] == 0)
                            {
                                bugsOnField[newRightPosition] = 1;
                                break;
                            }
                            else
                            {
                                newRightPosition += moveLenght;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        int newLeftPosition = currentPosition - moveLenght;
                        bugsOnField[currentPosition] = 0;
                        while (newLeftPosition >= 0 && newLeftPosition < bugsOnField.Length)
                        {
                            if (bugsOnField[newLeftPosition] == 0)
                            {
                                bugsOnField[newLeftPosition] = 1;
                                break;
                            }
                            else
                            {
                                newLeftPosition -= moveLenght;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', bugsOnField));
        }
    }
}