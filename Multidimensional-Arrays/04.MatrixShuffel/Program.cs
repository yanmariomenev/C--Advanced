
namespace _04.MatrixShuffel
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];
            var arr = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = lines[col];
                }
            }

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "END")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (tokens[0] == "swap" && tokens.Length == 5)
                {

                    var firstRow = int.Parse(tokens[1]);
                    var firstCol = int.Parse(tokens[2]);
                    var secondRow = int.Parse(tokens[3]);
                    var secondCol = int.Parse(tokens[4]);

                    if (firstRow >= 0 && firstRow <= rows - 1 && firstCol >= 0 && firstCol <= cols - 1
                        && secondRow >= 0 && secondRow <= rows - 1 && secondCol >= 0 && secondCol <= cols - 1)
                    {

                        var temp = arr[firstRow, firstCol];
                        arr[firstRow, firstCol] = arr[secondRow, secondCol];
                        arr[secondRow, secondCol] = temp;

                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write($"{arr[i, j]} ");
                            }

                            Console.WriteLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }
    }
}
