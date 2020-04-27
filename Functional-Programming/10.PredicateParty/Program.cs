using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var coming = Console.ReadLine()
               .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            ExecuteCommands(coming);
            PrintComingList(coming);
        }

        private static void PrintComingList(List<string> comming)
        {
            if (comming.Any())
            {
                var names = string.Join(", ", comming);
                Console.WriteLine($"{names} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ExecuteCommands(List<string> coming)
        {
            var command = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Party!")
            {
                if (command.Length < 3)
                {
                    command = Console.ReadLine()
                        .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                switch (command[1])
                {
                    case "StartsWith":
                        ForeachName(command[0], coming, n => n.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        ForeachName(command[0], coming, n => n.EndsWith(command[2]));
                        break;
                    case "Length":
                        ForeachName(command[0], coming, n => n.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void ForeachName(string command, List<string> coming, Func<string, bool> condition)
        {
            for (int i = coming.Count - 1; i >= 0; i--)
            {
                if (condition(coming[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            coming.RemoveAt(i);
                            break;
                        case "Double":
                            coming.Add(coming[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
