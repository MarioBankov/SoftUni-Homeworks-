using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            var dict = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] directoryFiles = info.GetFiles();
            foreach (var item in directoryFiles)
            {
                string name = item.Name;
                string extension =item.Extension;
                double size = item.Length / 1024d;

                if (dict.ContainsKey(extension)==false)
                {
                    dict.Add(extension, new Dictionary<string, double>());
                }
                if (dict[extension].ContainsKey(name)==false)
                {
                    dict[extension].Add(name, size);
                }
            }
            dict = dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            string pathToDesctop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";
            List<string> result = new List<string>();
            foreach (var item in dict)
            {
                 string extansion = item.Key;
                result.Add(extansion);
                foreach (var kvp in item.Value)
                {
                    string fileInfo = $"--{kvp.Key} - {Math.Round(kvp.Value, 3)}";
                    result.Add(fileInfo);
                }
            }
            File.WriteAllLines(pathToDesctop, result.ToArray());

        }
    }
}
