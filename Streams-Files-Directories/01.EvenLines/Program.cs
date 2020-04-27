using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var textPath = @"text.txt";
            var counter = 0;
            using (var sReader = new StreamReader(textPath))
            {
                string readText = sReader.ReadLine();

                while (readText != null)
                {
                    if (counter % 2 == 0)
                    {
                        var replaceSymbols = replaceSpecialSymbs(readText);
                        var reverseMethod = string.Join(" ", replaceSymbols.Split().Reverse());
                        Console.WriteLine(reverseMethod);
                    }
                    readText = sReader.ReadLine();
                    counter++;
                }
            }
            
        }

        private static string replaceSpecialSymbs(string readText)
        {
           return readText.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
