using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictureFolderPath = "copyMe.png";
            var targetPath = "../../../result.zip";
            //zipps all files
            //var pictureFolderPath = ".";
            //ZipFile.CreateFromDirectory(pictureFolderPath, targetPath);
            //ZipFile.ExtractToDirectory(targetPath, "../../");
            using (var archive = ZipFile.Open(targetPath,ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(pictureFolderPath, Path.GetFileName(pictureFolderPath));
            }
            ZipFile.ExtractToDirectory(targetPath, "../../");
        }
    }
}
