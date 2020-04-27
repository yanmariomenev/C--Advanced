using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace _02.ExxcelFunctions
{
   public class Program
    {

        private static StringBuilder sb;
        public static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            string[][] table = new string[rowCount][];
            createTable(table);
            var command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string header = command[1];
            sb = new StringBuilder();
            if (command[0] == "hide")
            {
                int index = FindHeader(header, table);

                for (int row = 0; row < table.Length; row++)
                {
                    var newList = new List<string>();
                    for (int col = 0; col < table[0].Length; col++)
                    {
                        if (col != index)
                        {
                            newList.Add(table[row][col]);
                        }
                    }
                    sb.AppendLine(string.Join(" | ", newList));
                }
               
                PrintResult(sb);
            }
            else if (command[0] == "sort")
            {
                
                int index = FindHeader(header, table);
                sb.AppendLine(string.Join(" | ", table[0]));
                foreach (var row in table.Skip(1).OrderBy(x => x[index]))
                {
                    sb.AppendLine($"{string.Join(" | ", row)}");
                }
                PrintResult(sb);
            }
            else if (command[0] == "filter")
            {
                string attribute = command[2];
                int index = FindHeader(header, table);
                sb.AppendLine(string.Join(" | ", table[0]));
                for (int row = 0; row < table.GetLength(0); row++)
                {
                    if (table[row][index] == attribute)
                    {
                        sb.AppendLine(string.Join(" | ", table[row]));
                    }
                }

                PrintResult(sb);
            }
        }

        private static void PrintResult(StringBuilder sb)
        {
            Console.WriteLine(sb.ToString().TrimEnd());
        }
       private static int FindHeader(string header, string[][] table)
       {
           int index = 0;
           for (int col = 0; col < table[0].Length; col++)
           {
               if (table[0][col] == header)
               {
                   index = col;
               }
           }

           return index;
        }
        private static void createTable(string[][]table)
        {
            for (int row = 0; row < table.Length; row++)
            {
                string[] currentRow = Console.ReadLine().Split(new[] {" ", ","}, StringSplitOptions.RemoveEmptyEntries);
                table[row] = currentRow;
            }
        }
    }
}
