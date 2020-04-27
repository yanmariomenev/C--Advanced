using System;
using System.Linq;

namespace _02.TwoByTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = InitializeMatrix();
            Console.WriteLine(CountEqualSquares(matrix));
        }

        private static int CountEqualSquares(char[][] matrix)
        {
            var count = 0;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] &&
                        matrix[i][j] == matrix[i + 1][j] &&
                        matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static char[][] InitializeMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new char[dimensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();
            }

            return matrix;
        }
    }
}
