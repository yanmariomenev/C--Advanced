using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var uniqueNames = new SortedSet<string>();
            for (int i = 0; i < count; i++)
            {
                var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < names.Length; j++)
                {
                    uniqueNames.Add(names[j]);
                }
            }

            foreach (var names in uniqueNames)
            {
                Console.Write(names + " ");
            }
        }
    }
}
