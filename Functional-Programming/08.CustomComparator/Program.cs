using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers = numbers.OrderBy(n => n % 2 != 0).ThenBy(n => n).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
