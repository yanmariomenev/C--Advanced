﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> deviders = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> nums = new List<int>();

            bool Check(int x, int y) => x % y != 0;

            for (int i = 1; i <= n; i++)
            {
                bool search = true;

                foreach (var divider in deviders)
                {
                    if (Check(i, divider))
                    {
                        search = false;
                        break;
                    }
                }

                if (search)
                {
                    nums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
