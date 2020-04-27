using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var characterLimit = int.Parse(Console.ReadLine());
            var listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Predicate<string> isLessChar = x => x.Length <= characterLimit;
            Action<string[]> printNames = names => Console.Write(string.Join(Environment.NewLine, names));
            Func<string[], string[]> lessCharacterNames = names =>
                {
                   return listOfNames = listOfNames.Where(l => isLessChar(l)).ToArray();
                    
                };
            var resultNames = lessCharacterNames(listOfNames);
            printNames(resultNames);
        }
    }
}
