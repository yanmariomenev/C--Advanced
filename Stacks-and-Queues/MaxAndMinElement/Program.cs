using System;
using System.Collections.Generic;
using System.Linq;
namespace MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < input; i++)
            {
                var numbers = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (numbers[0] == "1")
                {
                    var n = int.Parse(numbers[1]);
                    stack.Push(n);
                    continue;
                }
                if (stack.Count != 0)
                {
                    switch (numbers[0])
                    {
                        case "2":
                            stack.Pop();
                                break;
                        case "3":
                            Console.WriteLine(stack.Max());
                                break;
                        case "4":
                            Console.WriteLine(stack.Min());
                                break;
                        default:
                            break;
                    }
                }
            }

            if (stack.Count != 0)
            {
                var print = stack.ToArray();
                Console.WriteLine(string.Join(", ", print));
            }
            
        }
    }
}
