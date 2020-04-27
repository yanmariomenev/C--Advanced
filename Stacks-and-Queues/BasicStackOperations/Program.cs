using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            var count = input[0];
            var remove = input[1];
            for (int i = 0; i < count; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < remove; i++)
            {
                if (stack.Count <= remove)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Pop();
                }
            }

            var checkNum = input[2];
            if (stack.Contains(checkNum))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
            
        }
    }
}
