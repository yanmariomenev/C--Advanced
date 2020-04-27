using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size][];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var rightSum = 0;
            for (int i = 0; i < size; i++)
            {
                rightSum += matrix[i][i];
            }

            var leftSum = 0;
            for (int row = 0, col = size - 1; row < size; row++, col--)
            {
                leftSum += matrix[row][col];

            }

            Console.WriteLine(Math.Abs(rightSum - leftSum));
        }
    }
}
