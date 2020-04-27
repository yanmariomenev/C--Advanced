﻿
namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var petrolPumps = new Queue<int[]>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var petrolPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                petrolPumps.Enqueue(petrolPump);
            }

            var index = 0;
            
            while (true)
            {
                var totalFuel = 0;
                foreach (var petrolPump in petrolPumps)
                {
                    var petrolAmount = petrolPump[0];
                    var distance = petrolPump[1];
                    totalFuel += petrolAmount - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
