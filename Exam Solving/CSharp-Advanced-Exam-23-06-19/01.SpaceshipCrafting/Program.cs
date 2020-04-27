using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SpaceshipCrafting
{
   public class Program
    {
        static void Main(string[] args)
        {
            var liquids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var itemList = new Stack<int>(items);
            var collection = new List<string>();
            var materialsValue = new Dictionary<int, string>
            {
               [25] = "Glass",
               [50] = "Aluminium",
               [75] = "Lithium",
               [100] = "Carbon fiber"
            };

            while (liquids.Count != 0 && itemList.Count != 0)
            {
                var currentLiquid = liquids[0];
                var currentItem = itemList.Pop();
                var currentValue = currentLiquid + currentItem;

                if (!materialsValue.ContainsKey(currentValue))
                {
                    liquids.RemoveAt(0);
                    currentItem += 3;
                    itemList.Push(currentItem);
                }
                else
                {
                    collection.Add(materialsValue[currentValue]);
                    liquids.RemoveAt(0);
                }
            }
            if (collection.Contains("Lithium") &&
                collection.Contains("Carbon fiber") &&
                collection.Contains("Glass") &&
                collection.Contains("Aluminium"))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            if (liquids.Count != 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (itemList.Count != 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", itemList)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            Console.WriteLine($"Aluminium: {collection.Count(x => x == "Aluminium")}");
            Console.WriteLine($"Carbon fiber: {collection.Count(x => x == "Carbon fiber")}");
            Console.WriteLine($"Glass: {collection.Count(x => x == "Glass")}");
            Console.WriteLine($"Lithium: {collection.Count(x => x == "Lithium")}");
        }
    }

   
}
