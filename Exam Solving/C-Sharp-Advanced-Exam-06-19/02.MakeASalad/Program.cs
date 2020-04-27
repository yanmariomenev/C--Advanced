using System;

namespace _02.MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vegetables = new Queue<string>(Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList());

            Stack<int> calories = new Stack<int>(Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            List<int> madeSalads = new List<int>();

            while (vegetables.Count != 0 && calories.Count != 0)
            {
                string currentVegetable = vegetables.Dequeue();
                int currentCalories = calories.Pop();

                int currentVegetablesCalories = ExecuteVegetableCalories(currentVegetable);

                if (currentCalories > currentVegetablesCalories)
                {
                    int left = currentCalories - currentVegetablesCalories;

                    while (left > 0 && vegetables.Count != 0)
                    {
                        currentVegetable = vegetables.Dequeue();
                        left -= ExecuteVegetableCalories(currentVegetable);
                    }
                }

                madeSalads.Add(currentCalories);
            }

            Console.WriteLine(string.Join(" ", madeSalads));

            if (calories.Count != 0)
            {
                Console.WriteLine(string.Join(" ", calories));
            }
            else if (vegetables.Count != 0)
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
        }

        private static int ExecuteVegetableCalories(string currentVegetables)
        {
            int calories = 0;

            switch (currentVegetables)
            {
                case "tomato":
                    calories = 80;
                    break;

                case "carrot":
                    calories = 136;
                    break;

                case "lettuce":
                    calories = 109;
                    break;

                case "potato":
                    calories = 215;
                    break;

                default:
                    break;
            }

            return calories;
        }
    }
}
