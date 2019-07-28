using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles2._0
{
     public class Article
    {
        public string Tite { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Article> articleList = new List<Article>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] data = Console.ReadLine().Split(',');
                string titel = data[0];
                string content = data[1];
                string author = data[2];

                var article = new Article()
                {
                    Tite = titel,
                    Content = content,
                    Author = author
                };
                articleList.Add(article);
            }
            String sortetBy = Console.ReadLine();
            if (sortetBy=="title")
            {
                foreach (var item in articleList.OrderBy(x=>x.Tite))
                {
                    Console.WriteLine("{0} - {1}: {2}",item.Tite,item.Content,item.Author);
                }
            }
            else if (sortetBy=="content")
            {
                foreach (var item in articleList.OrderBy(x => x.Content))
                {
                    Console.WriteLine("{0} -{1}:{2}", item.Tite, item.Content, item.Author);
                }
            }
            
        }
    }
}
