using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = n =>
                Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", n));
            var inputNames = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            printNames(inputNames);
        }
    }
}
