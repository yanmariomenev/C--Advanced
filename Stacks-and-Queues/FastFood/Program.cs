using System;
using System.Collections.Generic;
using System.Linq;
namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            var foodNeeded = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var line = new Queue<int>(foodNeeded);
            Console.WriteLine(line.Max());
            var allOrders = line.Sum();

            while (line.Count > 0)
            {
                int currentOrder = line.Peek();
                if (food - currentOrder < 0)
                {
                    break;
                }

                food -= line.Dequeue();
            }
            if (line.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {

                Console.WriteLine($"Orders left: {string.Join(" ",line)}");
            }
        }
    }
}