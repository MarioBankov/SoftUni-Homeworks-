
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
   public  class Library : IEnumerable<Book>
    {
        private List<Book> books;
     

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books.Sort(new BookComparator());
            
        }

        public IEnumerator<Book> GetEnumerator()
        {
            var  enumerator =new LibralyIterator(books);
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        

    }
}
