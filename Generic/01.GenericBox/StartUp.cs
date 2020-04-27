using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01.GenericBox
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            Box<double> myBox = new Box<double>();
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var input =double.Parse(Console.ReadLine()); ;
                myBox.Add(input);
            }

            double stringToCompare = double.Parse(Console.ReadLine());
            myBox.Compare(stringToCompare);

            var result = myBox.countGreater;
            Console.WriteLine(result);
        }
    }
}
