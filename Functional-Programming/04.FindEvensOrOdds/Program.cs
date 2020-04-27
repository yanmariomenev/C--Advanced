using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {

            var bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lowerBounds = bounds[0];
            int upperBounds = bounds[1];

            List<int> numbers = new List<int>();
            var numberType = Console.ReadLine();
            for (int i = lowerBounds; i <= upperBounds; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;
            Action<List<int>> printNumbers = n => Console.WriteLine(string.Join(" ", n));
            if (numberType == "odd")
            {
               numbers = numbers.Where(x => isOdd(x)).ToList();
            }
            else
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }

            printNumbers(numbers);
        }
    }
}
