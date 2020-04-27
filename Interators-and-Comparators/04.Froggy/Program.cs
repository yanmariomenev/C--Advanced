using System;
using System.Linq;

namespace _04.Froggy
{
   public class Program
    {
       public static void Main(string[] args)
       {
           var numbers = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

           var stones = new Lake(numbers.ToList());

           Console.WriteLine(string.Join(", ", stones));
        }
    }
}
