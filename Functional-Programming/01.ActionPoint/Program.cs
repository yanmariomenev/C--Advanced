using System;
using System.Runtime.InteropServices;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            var inputNames = Console.ReadLine()
                .Split(' ' , StringSplitOptions.RemoveEmptyEntries);
            printNames(inputNames);
        }
    }
}
