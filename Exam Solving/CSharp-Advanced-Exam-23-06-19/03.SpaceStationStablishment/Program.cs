using System;
using System.ComponentModel;
using System.Linq;

namespace _03.SpaceStationStablishment
{

    public class Program
    {
        static int stephenRow;
        static int stephenCol;
        static int blackHoleRow;
        static int blackHoleCol;
        static int blackHole2Row;
        static int blackHole2Col;
        static int energy;
        private char[][] field;
        public static void Main()
        {

            int rowsCount = int.Parse(Console.ReadLine());

            char[][] field = new char[rowsCount][];
            InitializeMatrix(field);
            FindBlackHoles(field);
            FindStephenPosition(field);

            bool won = false;

            while (energy >= 50)
            {
                string[] turn = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string moveDirection = turn[0];


                field[stephenRow][stephenCol] = '-';

                MoveInDirection(field, moveDirection);


                char symbolOnNextStep = field[stephenRow][stephenCol];

                if (char.IsDigit(symbolOnNextStep))
                {
                   
                    energy += symbolOnNextStep;
                    field[stephenRow][stephenCol] = '-';
                }
                else if (symbolOnNextStep == 'O')
                {

                    field[stephenRow][stephenCol] = '-';
                    break;
                }

            }

            PrintOutput(field, won, energy);
        }

        private static void PrintOutput(char[][] field, bool won, int energy)
        {
            if (won)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {stephenRow};{stephenCol}.");
            }

            PrintMatrix(field);
        }

        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = field[row];

                Console.WriteLine(String.Join("", currentRow));
            }
        }
        private static void FindBlackHoles(char[][] field)
        {
            bool found1 = false;
            bool found2 = false;
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'O')
                    {
                        blackHoleRow = row;
                        blackHoleCol = col;
                        found1 = true;
                        break;
                    }
                }

                for (int i = blackHoleRow; i < field.Length; i++)
                {
                    for (int j = blackHole2Col; j < field[i].Length; j++)
                    {
                        char symbol = field[i][j];

                        if (symbol == 'O')
                        {
                            blackHole2Row = i;
                            blackHole2Col = j;
                            found2 = true;
                            break;
                        }
                    }
                }

            }
        }
        private static void MoveInDirection(char[][] field, string moveDirection)
        {
            char symbolOnNextStep = field[stephenRow][stephenCol];
            if (moveDirection == "up")
            {
                if (stephenRow - 1 >= 0)
                {
                    stephenRow--;
                }
                if (char.IsDigit(symbolOnNextStep))
                {
                    energy += symbolOnNextStep;
                    field[stephenRow][stephenCol] = '-';
                }
            }
            else if (moveDirection == "down")
            {
                if (stephenRow + 1 < field.Length)
                {
                    stephenRow++;
                }
                if (char.IsDigit(symbolOnNextStep))
                {
                    energy += symbolOnNextStep;
                    field[stephenRow][stephenCol] = '-';
                }
            }
            else if (moveDirection == "left")
            {
                if (stephenCol - 1 >= 0)
                {
                    stephenCol--;
                }
                if (char.IsDigit(symbolOnNextStep))
                {
                    energy += symbolOnNextStep;
                    field[stephenRow][stephenCol] = '-';
                }
            }
            else if (moveDirection == "right")
            {
                if (stephenCol + 1 < field[stephenRow].Length)
                {
                    stephenCol++;
                }
                if (char.IsDigit(symbolOnNextStep))
                {
                    energy += symbolOnNextStep;
                    field[stephenRow][stephenCol] = '-';
                }

            }
        }


        private static void FindStephenPosition(char[][] field)
        {
            bool found = false;

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'S')
                    {
                        stephenRow = row;
                        stephenCol = col;

                        found = true;

                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
        }

        private static void InitializeMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                field[row] = currentRow;
            }
        }
    }
}
