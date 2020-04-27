using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Action<List<int>> printNumbers = n => Console.WriteLine(string.Join(" ", n));
            while (true)
            {
                var commands = Console.ReadLine();
                if (commands =="end")
                {
                    break;
                }
                else if (commands == "add")
                {
                    inputNumbers = inputNumbers.Select(i => i + 1).ToList();
                }
                else if (commands == "multiply")
                {
                    inputNumbers = inputNumbers.Select(i => i * 2).ToList();
                }
                else if (commands == "subtract")
                {
                    inputNumbers = inputNumbers.Select(i => i - 1).ToList();
                }
                else if (commands == "print")
                {
                    printNumbers(inputNumbers);
                }
            }
        }
    }
}
