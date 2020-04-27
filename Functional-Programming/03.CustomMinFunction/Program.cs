using System;
using System.Globalization;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printNumber = p => Console.WriteLine(p);
            Func<int[], int> lowestNumber = numbers =>
            {
                int minValue = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };

        var inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var minNumber = lowestNumber(inputNumbers);
        printNumber(minNumber);
        }
    }
}
