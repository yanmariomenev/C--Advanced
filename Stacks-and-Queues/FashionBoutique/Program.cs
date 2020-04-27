using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rackSize = int.Parse(Console.ReadLine());
            var clothesStack = new Stack<int>(clothes);
            var counter = 1;
            var weight = 0;
            while (true)
            {
                
                if (clothesStack.Count == 0)
                {
                    break;
                }

                if (weight + clothesStack.Peek() <= rackSize)
                {
                    weight += clothesStack.Pop();
                }
                else
                {
                    weight = 0;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
