using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, " Dorothy Sayers", "Robert Eustace");
            Book bookTree = new Book("TEST", 1, "TEST", "TEST");
            Book bookTree1 = new Book("The Documents in the Case", 2001, " Dorothy Sayers", "Robert Eustace");
            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo,bookTree,bookTree1);
            foreach (var item in libraryTwo)
            {
                Console.WriteLine("{0} {1} {2}",item.Title,item.Year,string.Join(" ",item.Authors));
            }
            foreach (var item in libraryOne)
            {
                Console.WriteLine(item);
            }


        }
    }
}
