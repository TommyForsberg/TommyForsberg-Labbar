using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10_Delegater
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book> { new Book { Title = "The lord of the rings", Genre = Book.GenreType.Adventure, Pages = 429, Price = 239 },
            new Book { Title = "Inferno", Genre = Book.GenreType.Classic, Pages = 230, Price = 139 },
             new Book { Title = "Sagolandet", Genre = Book.GenreType.Comedy, Pages = 159, Price = 239 } ,
             new Book { Title = "Nybyggarna", Genre = Book.GenreType.Classic, Pages = 499, Price = 239 } ,
             new Book { Title = "Förvandlingen", Genre = Book.GenreType.Thriller, Pages = 129, Price = 39 },
            new Book { Title = "Jane Eyre", Genre = Book.GenreType.Drama, Pages = 319, Price = 79} };
        }

        public void  PrintWhere(BookFilter filter)
        {
            foreach(var book in Books)
            {
                if (filter(book))
                    Console.WriteLine(book.Title);
            }
        }
    }
}
