
using System.Security.Claims;

namespace _03.MaximumSum
{
    using System;
    using System.Linq;
   public class Program
    {
       public static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            var targetRow = 0;
            var targetCol = 0;
            var maxSum = 0;
            for (int row = 0; row < matrix.GetLength(0) -2; row++) // - 2 to not go out of the array
            {
                for (int col = 0; col < matrix.GetLength(1) -2; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]+
                                     matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        targetCol = col;
                        targetRow = row;
                    }
                }
            }

            Console.WriteLine("Sum = "+ maxSum);
            for (int row = targetRow; row <= targetRow+2; row++)
            {
                for (int col = targetCol; col <= targetCol+2; col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
