
namespace _05.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToCharArray();
            var charCounter = new SortedDictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentChar = words[i];
                if (!charCounter.ContainsKey(currentChar))
                {
                    charCounter.Add(currentChar, 1);
                }
                else
                {
                    charCounter[currentChar] += 1;
                }
            }

            foreach (var (key , value) in charCounter)
            {
                Console.Write($"{key}: {value} time/s");
                Console.WriteLine();
            }
        }
    }
}
