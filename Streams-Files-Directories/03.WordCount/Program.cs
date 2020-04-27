using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var textPath = "text.txt";
            var wordsPath = "words.txt";

            var textLines = File.ReadAllLines(textPath);
            var words = File.ReadAllLines(wordsPath);

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var convertToLower = word.ToLower();
                if (!wordsInfo.ContainsKey(convertToLower))
                {
                    wordsInfo.Add(convertToLower, 0);
                }
            }

            foreach (var textLine in textLines)
            {
                var currentLine = textLine
                    .ToLower()
                    .Split(new char[] {' ', '-', ',', '?', '!', '.', '\'', ':', ';'});

                foreach (var currentWord in currentLine)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord]++;
                    }
                }
            }

            var actualResultPath = "actualResult.txt";
            var expectedResultPath = "expectedResult.txt";
            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText(actualResultPath,$"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}
