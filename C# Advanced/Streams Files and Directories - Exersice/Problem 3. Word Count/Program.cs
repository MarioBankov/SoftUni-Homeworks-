using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToWords = "words.txt";
            string pathToText = "text.txt";
            string pathToActualResult = "actualResult.txt";
            string pathToeepectedResult = "expectedResult.txt";


            string[] words = File.ReadAllLines(pathToWords);
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (dic.ContainsKey(words[i])==false)
                {
                    dic.Add(words[i], 0);
                }
            }

            string text = File.ReadAllText(pathToText);
            string[] textToWords = text.Replace("-", "").Replace(".", "").Replace(",", "").Replace("!", "")
                .Replace("?", "").ToLower().Split();
            for (int i = 0; i < textToWords.Length; i++)
            {
                if (dic.ContainsKey(textToWords[i]))
                {
                    dic[textToWords[i]]++;
                }
            }
            
            string[] linesInArray = new string[dic.Count];
            int lineCount = 0;
            foreach (var item in dic)
            {
                string result = $"{item.Key} - {item.Value}";
                linesInArray[lineCount] = result;
                lineCount++;
            }
            lineCount = 0;
            File.WriteAllLines(pathToActualResult, linesInArray);
            foreach (var item in dic.OrderByDescending(x=>x.Value))
            {
                string result = $"{item.Key} - {item.Value}";
                linesInArray[lineCount] = result;
                lineCount++;
            }
            File.WriteAllLines(pathToeepectedResult, linesInArray);
        }

      
    }
}
