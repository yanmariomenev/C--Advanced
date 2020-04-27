using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < count[0]; i++)
            {
                var firstNumSet = int.Parse(Console.ReadLine());
                firstSet.Add(firstNumSet);
            }
            for (int i = 0; i < count[1]; i++)
            {
                var secondNumSet = int.Parse(Console.ReadLine());
                secondSet.Add(secondNumSet);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
