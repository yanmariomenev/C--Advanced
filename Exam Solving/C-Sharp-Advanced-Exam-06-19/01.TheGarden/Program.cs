using System;
using System.Linq;

namespace _01.TheGarden
{
    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            //Input
            int rowsCount = int.Parse(Console.ReadLine());
            char[][] garden = new char[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
            {
                char[] sub =
                    Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                garden[row] = sub;
            }
            int lettuce = 0;
            int potatos = 0;
            int carrots = 0;
            int harmed = 0;
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end of harvest")
                {
                    break;
                }
                string[] info =
                    input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = info[0];
                int row = int.Parse(info[1]);
                int col = int.Parse(info[2]);
                if (command == "harvest" && PositionValidator(garden, row, col))
                {
                    char currentPositionChar = garden[row][col];
                    switch (currentPositionChar)
                    {
                        case 'P': potatos++; break;
                        case 'C': carrots++; break;
                        case 'L': lettuce++; break;
                        default: break;
                    }
                    garden[row][col] = ' ';
                }
                else if (command == "mole")
                {
                    string direction = info[3];
                    while (PositionValidator(garden, row, col))
                    {
                        char currenPosition = garden[row][col];
                        if (currenPosition == 'P' || currenPosition == 'C' || currenPosition == 'L')
                        {
                            harmed++;
                            garden[row][col] = ' ';
                        }
                        Position newPosition = Move(row, col, direction);
                        row = newPosition.Row;
                        col = newPosition.Col;
                        if (PositionValidator(garden, row, col) && garden[row][col] == ' ')
                        {
                            break;
                        }
                    }
                }
            }
            //Print
            for (int row = 0; row < garden.Length; row++)
            {
                Console.WriteLine(string.Join(' ', garden[row]));
            }
            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatos}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmed}");

        }

        private static Position Move(int row, int col, string direction)
        {
            int currentRow = row;
            int currentCol = col;
            if (direction == "up")
            {
                currentRow -= 2;
            }
            else if (direction == "down")
            {
                currentRow += 2;
            }
            else if (direction == "left")
            {
                currentCol -= 2;
            }
            else if (direction == "right")
            {
                currentCol += 2;
            }
            return new Position(currentRow, currentCol);
        }

        private static bool PositionValidator(char[][] garden, int row, int col)
        {
            bool valid = false;
            if (row >= 0 && col >= 0 && row < garden.Length && col < garden[row].Length)
            {
                valid = true;
            }
            return valid;
        }
    }

}
