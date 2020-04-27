
namespace _07.KnightGame
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var board = new char[rows, rows];
            var indexes = new int[]
            {
                1,2,
                1,-2,
                -1,2,
                -1,-2,
                2,1,
                2,-1,
                -2,1,
                -2,-1
            };
            for (int row = 0; row < rows; row++)
            {
                var inputRow = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < rows; col++)
                {
                    board[row, col] = inputRow[col];
                }
            }

            var counter = 0;
            while (true)
            {
                var maxCount = 0;
                var knightRow = 0;
                var knightCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentCounter = 0;
                        if (board[row,col] =='K')
                        {
                            for (int i = 0; i < indexes.Length; i += 2)
                            {
                                if (isInside(board,row +indexes[i], col + indexes[i + 1])
                                    && board[row+indexes[i],col + indexes[i + 1]] == 'K')
                                {
                                    currentCounter++;
                                }
                            }
                        }

                        if (currentCounter > maxCount)
                        {
                            maxCount = currentCounter;
                            knightRow = row;
                            knightCol = col;
                        }
                    }

                }

                if (maxCount == 0)
                {
                    break;
                }

                board[knightRow, knightCol] = '0';
                counter++;

            }

            Console.WriteLine(counter);
        }

        private static bool isInside(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) && desiredRow >= 0 &&
                   desiredCol < board.GetLength(1) && desiredCol >= 0;
        }
    }
}
