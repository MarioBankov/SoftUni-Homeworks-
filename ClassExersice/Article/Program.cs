using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    public class Article
    {
        public Article(string  title, string content, string author)
        {
            this.Title = title;
            Content = content;
            Author = author;
        }
        public  string Title { get; set; }
        public  string Content { get; set; }
        public  string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string name)
        {
            Title = name;
        }
        public override string ToString()
        {
            return $"{Title} -{Content}-{Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(',');
            string title = data[0];
            string content = data[1];
            string author = data[2];
            Article article = new Article(title, content, author);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split(':');

                string command = token[0];
                if (command=="Edit")
                {
                    string newContent = token[1];
                    article.Edit(newContent);
                }
                else if (command=="ChangeAuthor")
                {
                    string newAuthor = token[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command=="Rename")
                {
                    string newName = token[1];
                    article.Rename(newName);
                }
            }
            Console.WriteLine(article);
        }
    }
}
