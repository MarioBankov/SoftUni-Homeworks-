using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book: IComparable<Book>
    {
        public Book(string title , int year ,params string[] autors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = autors.ToList();
        }
        public string Title { get; private set; }
        public int Year { get;private set; }
        public List<string> Authors { get;  private set; }

        public int CompareTo(Book other)
        {
            var result = this.Year.CompareTo(other.Year);
            if (result==0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            
            return result;
            
        }
        public override string ToString()
        {
            return $"{this.Title} {this.Year}";
        }
    }
}
