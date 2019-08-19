using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibralyIterator : IEnumerator<Book>
    {
        private  readonly List<Book> books;
        private int index;

        public LibralyIterator(List<Book>books)
        {
            Reset();
            this.books = new List<Book>(books); 
        }
        public Book Current => this.books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            
            return ++index < books.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
