using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                var names = Console.ReadLine();
                uniqueNames.Add(names);
            }

            foreach (var uniqueName in uniqueNames)
            {
                Console.WriteLine(uniqueName);
            }
        }
    }
}
