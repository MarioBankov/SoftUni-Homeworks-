using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="3:1")
                {
                    Console.WriteLine(string.Join(" ",text));
                    break;
                }
                string[] tokens = command.Split();
                
                if (tokens[0] == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex>text.Count-1|| endIndex<0)
                    {
                        continue;
                    }
                    if (endIndex>text.Count-1)
                    {
                        endIndex = text.Count - 1;
                    }
                    Merge(text, startIndex, endIndex);
                    
                }
                else if (tokens[0]=="divide")
                {
                    int indexOfWord = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);
                    string element = text[indexOfWord];
                    text.RemoveAt(indexOfWord);

                    
                   List<string>newWOrds=Divide(element, parts);
                    text.InsertRange(indexOfWord, newWOrds);


                }
            }
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partLenght = element.Length / parts;
            int lastPartLent = partLenght + element.Length % parts;
            for (int i = 0; i < parts; i++)
            {
                string word = element.Substring(i*partLenght,partLenght);
                
                if (i==parts-1)
                {
                    word = element.Substring(i * partLenght, lastPartLent);
                }
                newWords.Add(word);
            }
            return newWords;
        }

        private static void Merge(List<string> text, int startIndex, int endIndex)
        {
            string sb = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string word = text[i];
                sb = sb + word;
            }
            text.RemoveRange(startIndex, endIndex - startIndex + 1);
            text.Insert(startIndex, sb);
        }
    }
}
