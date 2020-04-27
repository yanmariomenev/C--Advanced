using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileArray = Directory.GetFiles(".", "*.*");

            var directoryInfo = new Dictionary<string, Dictionary<string, double>>();
            var fileSizeInfo = new DirectoryInfo(".");

            var allFiles = fileSizeInfo.GetFiles();
            foreach (var fileInfo in allFiles)
            {
                var fileSize = fileInfo.Length / 1024d;
                var fileName = fileInfo.Name;
                var extension = fileInfo.Extension;

                if (!directoryInfo.ContainsKey(extension))
                {
                    directoryInfo.Add(extension,new Dictionary<string, double>());
                }

                if (!directoryInfo[extension].ContainsKey(fileName))
                {
                    directoryInfo[extension].Add(fileName,fileSize);
                }
            }

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            var sortedDictionary = directoryInfo.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var (extension,value) in directoryInfo)
            {
                File.AppendAllText(desktopPath,extension + Environment.NewLine);
                foreach (var (fileName , size) in value.OrderBy(x => x.Value))
                {
                   File.AppendAllText(desktopPath, $"--{fileName} - {Math.Round(size , 3)}kb"+ Environment.NewLine);
                }
            }

        }
    }
}
