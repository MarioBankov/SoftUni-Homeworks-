using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }
                comments.Add(comment);
            }
            Console.WriteLine("<h1> \n {0}\n </h1>", article);
            Console.WriteLine("<article> \n {0}\n </article>", content);
            for (int i = 0; i < comments.Count; i++)
            {
                Console.WriteLine("<div> \n {0} \n </div> ", comments[i]);
            }
        }
    }
}
