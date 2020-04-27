using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var textPath = @"text.txt";
            var outputPath = "output.txt";
            var textLines = File.ReadAllLines(textPath);

            var lineCounter = 1;
            foreach (var textLine in textLines)
            {
                var letterCounter = textLine.Count(char.IsLetter);
                var puncCounter = textLine.Count(char.IsPunctuation);
                File.AppendAllText(outputPath,$"Line {lineCounter}: {textLine} ({letterCounter})({puncCounter}){Environment.NewLine}");
                lineCounter++;
            }
        }
    }
}
