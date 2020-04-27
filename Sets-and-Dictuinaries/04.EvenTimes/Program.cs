using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var repeatedNum = new Dictionary<int , int>();
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (!repeatedNum.ContainsKey(number))
                {
                    repeatedNum.Add(number, 1);
                }
                else
                {
                    repeatedNum[number] += 1;
                }
                
            }
            
            foreach (var (key , value) in repeatedNum)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}
