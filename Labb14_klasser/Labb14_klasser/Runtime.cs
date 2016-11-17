using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14_klasser
{
    class Runtime
    {
        public void Start()
        {
            var repository = new Repository();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sök efter författare:");
                repository.Print(Console.ReadLine());
            }
            #region part1
            //var author1 = new Author { Name = "Fjodor Dosojevskij", Age = 89 };
            //var author2 = new Author { Name = "Leo Tolstoj", Age = 89 };
            //var author3 = new Author { Name = "Bill Finger", Age = 52 };
            //var author4 = new Author { Name = "Suzanne wilder", Age = 73 };
            //var book1 = new Book { Title = "Idioten", Author = author1, Genre = Book.GenreType.Classic, Pages = 329, ReleaseDate = new DateTime(1889, 11, 23) };
            //var book2 = new Book { Title = "Krig och Fred", Author = author2, Genre = Book.GenreType.Classic, Pages = 401, ReleaseDate = new DateTime(1865, 10, 02) };
            //var magazine1 = new Magazine { Title = "Batman", Author = author3, ReleaseDate = new DateTime(1956, 03, 14), Volume = 1};
            //var paper1 = new Paper { Title = "The emergence of cinematic time", Author = author4, ReleaseDate = new DateTime(1989, 04, 14), University = "Uppsala Universitet"};
            #endregion
        }
    }
}
