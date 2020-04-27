
namespace _06.BombTheBasement
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            var basements = new int[rows][];

            for (int i = 0; i < basements.Length; i++)
            {
                basements[i] = new int[cols];
            }
            var coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int targetRow = coordinates[0];
            int targetCol = coordinates[1];
            int radius = coordinates[2];

            for (int row = 0; row < basements.Length; row++)
            {
                for (int col = 0; col < basements[row].Length; col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <=
                                      Math.Pow(radius, 2);
                    if (isInRadius)
                    {
                        basements[row][col] = 1;
                    }
                }
            }

            for (int col = 0; col < basements[0].Length; col++)
            {
                var counter = 0;
                for (int row = 0; row < basements.Length; row++)
                {
                    if (basements[row][col] == 1)
                    {
                        counter++;
                        basements[row][col] = 0;
                    }
                }

                for (int row = 0; row < counter; row++)
                {
                    basements[row][col] = 1;
                }

            }

            foreach (var row in basements)
            {
                Console.WriteLine(string.Join("",row));
            }
        }
    }
}
