using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Problem_4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "CopyMe.png";
            string CopyPath = "CopyMeCopy.png";

            var reader = new FileStream(filePath, FileMode.Open);
            using (reader)
            {

                byte[] buffer = new byte[reader.Length];
                int size = reader.Read(buffer, 0, buffer.Length);

                using (var wrieter = new FileStream(CopyPath, FileMode.Create))
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        Console.WriteLine(buffer[i]);
                    }
                   
                    wrieter.Write(buffer, 0, size);

                }
            }

        }
    }
}
