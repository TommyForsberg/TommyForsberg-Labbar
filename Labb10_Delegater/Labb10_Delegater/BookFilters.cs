using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10_Delegater
{
    class BookFilters
    {
        public static bool IsNovel(Book book)
        {
            return book.Pages >= 200;
        }

        public static bool IsShort(Book book)
        {
            return book.Pages < 200;
        }

        public static bool IsAdventure(Book book)
        {
            return book.Genre == Book.GenreType.Adventure;
        }

        public static bool IsDrama(Book book)
        {
            return book.Genre == Book.GenreType.Drama;
        }

        public static bool IsCheap(Book book)
        {
            return book.Price < 200;
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price > 200;
        }
    }
}
