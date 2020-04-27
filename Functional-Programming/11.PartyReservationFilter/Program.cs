using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestList = new List<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            var filters = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {

                var commands = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add filter")
                {
                    filters.Add(commands[1] + " " + commands[2]);
                }
                else if (commands[0] == "Remove filter")
                {
                    filters.Remove(commands[1] + " " + commands[2]);
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split(' ');

                if (commands[0] == "Starts")
                {
                    guestList = guestList.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    guestList = guestList.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    guestList = guestList.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    guestList = guestList.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (guestList.Any())
            {
                Console.WriteLine(string.Join(" ", guestList));
            }
        }
    }
}
