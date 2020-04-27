using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var line = new Queue<int>();
            var count = input[0];
            var remove = input[1];
            for (int i = 0; i < count; i++)
            {
                line.Enqueue(numbers[i]);
            }

            for (int i = 0; i < remove; i++)
            {
                if (line.Count <= remove)
                {
                    line.Dequeue();
                }
                else
                {
                    line.Dequeue();
                }
            }

            var checkNum = input[2];
            if (line.Contains(checkNum))
            {
                Console.WriteLine("true");
            }
            else if (line.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(line.Min());
            }
        }
    }
}
