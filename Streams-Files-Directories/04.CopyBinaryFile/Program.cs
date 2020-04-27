using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturePath = "copyMe.png";
            var pictureCopyPath = "copyMe-copy.png";

            using (var streamReader = new FileStream(picturePath,FileMode.Open))
            {
                using (var streamWriter = new FileStream(pictureCopyPath,FileMode.Create))
                {
                    while (true)
                    {
                        var byteArray = new byte[4096];
                        var size = streamReader.Read(byteArray, 0, byteArray.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }

        }
    }
}
