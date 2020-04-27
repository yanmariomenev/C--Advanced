using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var divisibleNumber = int.Parse(Console.ReadLine());
            Predicate<int> isDevisible = x => x % divisibleNumber != 0;
            Func<List<int>, List<int>> divisbleResult = number =>
            {
                return numbers = numbers.Where(x => isDevisible(x))
                    .Reverse()
                    .ToList();
            };
            Action<List<int>> printNumbers = n => Console.Write(string.Join(" ", n));
            var devisibleNumberOutput = divisbleResult(numbers);
            printNumbers(devisibleNumberOutput);
        }
    }
}
