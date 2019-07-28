using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("files", "input.txt");
            
           
            using (var inputFile=new FileStream(path,FileMode.Open))
            {
                long size = inputFile.Length;
                int partSize = (int)Math.Ceiling((double)size / 4);
                byte[] buffer = new byte[partSize];
                for (int i = 1; i <= 4; i++)
                {
                    using (var outputFile = new FileStream($"Part-{i}.txt",FileMode.Create))
                    {
                        int readedBytes = inputFile.Read(buffer,0,partSize);
                        outputFile.Write(buffer, 0, readedBytes);
                    }
                }
            }
        }
    }
}
