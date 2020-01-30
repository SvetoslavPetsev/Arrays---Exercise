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

            int[] bugsOnField = GetFieldAndBugsStartPoint(sizeOfField, startPlace);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input
                    .Split(" ")
                    .ToArray();

                int currentPosition = int.Parse(command[0]);

                string direction = command[1];

                int moveLenght = int.Parse(command[2]);

                if (currentPosition < 0 || currentPosition > bugsOnField.Length - 1)
                {
                    continue;
                }

                else if (bugsOnField[currentPosition] == 1)
                {
                    int indexdirection = GetDirection(direction);

                    int newPosition = currentPosition + (moveLenght * indexdirection);

                    bugsOnField[currentPosition] = 0;

                    while (newPosition >= 0 && newPosition <= bugsOnField.Length - 1)
                    {

                        if (bugsOnField[newPosition] == 0)
                        {
                            bugsOnField[newPosition] = 1;
                            break;
                        }
                        else
                        {
                            newPosition += moveLenght * indexdirection;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", bugsOnField));
        }

        private static int GetDirection(string direction)
        {
            int indexDirection = 1;
            if (direction == "left")
            {
                indexDirection = -1;
            }
            return indexDirection;
        }

        private static int[] GetFieldAndBugsStartPoint(int sizeOfField, int[] startPlace)
        {
            int[] bugsOnField = new int[sizeOfField];

            for (int i = 0; i < startPlace.Length; i++)
            {
                int currentposition = startPlace[i];

                for (int j = 0; j < bugsOnField.Length; j++)
                {
                    int positionOnField = j;

                    if (currentposition == positionOnField)
                    {
                        bugsOnField[j] = 1;
                        break;
                    }
                }
            }
            return bugsOnField;
        }
    }
}
