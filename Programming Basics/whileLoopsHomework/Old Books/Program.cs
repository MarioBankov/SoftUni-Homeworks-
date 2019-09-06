using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());

            int bookchecked = 0;
            while (bookchecked<capacity)
            {
                string book = Console.ReadLine();
                if (searchedBook==book)
                {
                    Console.WriteLine($"You checked {bookchecked} books and found it.");
                    break;
                }
                else
                {
                    bookchecked++;
                }
            }
            if (bookchecked>=capacity)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine("You checked {0} books.",bookchecked);
            }
        }
    }
}
