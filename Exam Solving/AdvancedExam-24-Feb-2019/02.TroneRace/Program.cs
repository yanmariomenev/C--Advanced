using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.TroneRace
{
    class Program
    {
        private static char[][] battleField;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            battleField = new char[rows][];

            Initialize();
        }

        private static void Initialize()
        {
            for (int i = 0; i < battleField.Length; i++)
            {
                char[] input = Console.Read().ToCharArray();
                battleField[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    battleField[i][j] = input[j];
                }
            }
        }
    }
}
