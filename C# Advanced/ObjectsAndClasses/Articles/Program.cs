using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split(", ").ToList();
                Article article = new Article(data[0], data[1], data[2]);
                list.Add(article);
            }
            string format = Console.ReadLine();
            if (format=="title")
            {
                list = list.OrderBy(x => x.Title).ToList();
            }
            else if (format=="content")
            {
                list = list.OrderBy(x => x.Content).ToList();
            }
            else if (format=="author")
            {
                list = list.OrderBy(x => x.Author).ToList();
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
           
        }
    }
    class Article
    {
        public Article(string title ,string content,string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChengeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string name)
        {
            this.Title = name;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
