using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10_Delegater
{
    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();
            BookFilter isNovelFilter = BookFilters.IsNovel;
            BookFilter isGenreAdventureFilter = BookFilters.IsAdventure;
            BookFilter isShortStoryFilter = BookFilters.IsShort;
            BookFilter isGenreDramaFilter = BookFilters.IsDrama;
            BookFilter isCheapFilter = BookFilters.IsCheap;
            BookFilter isExpensiveFilter = BookFilters.IsExpensive;

            Console.WriteLine("Novels: ");
            manager.PrintWhere(isNovelFilter);
            Console.WriteLine("\nAdventure");
            manager.PrintWhere(isGenreAdventureFilter);
            Console.WriteLine("\nShort stories:");
            manager.PrintWhere(isShortStoryFilter);
            Console.WriteLine("\nThriller:");
            manager.PrintWhere(book => book.Genre == Book.GenreType.Thriller);
            Console.WriteLine("\nDrama:");
            manager.PrintWhere(isGenreDramaFilter);
            Console.WriteLine("\nCheap books:");
            manager.PrintWhere(isCheapFilter);
            Console.WriteLine("\nExpensive books");
            manager.PrintWhere(isExpensiveFilter);

        }
    }
}
