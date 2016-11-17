using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14_klasser
{
    class Repository
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<Paper> Papers { get; set; }

        public Repository()
        {

            Authors = new List<Author>
            {
                new Author {Name = "Fjodor Dostojevskij", Age = 89 },
                new Author {Name = "Leo Tolstoj", Age = 78 },
                new Author { Name = "Bill Finger", Age = 52 },
                new Author { Name = "Suzanne Wilder", Age = 73 }

        };

            Papers = new List<Paper>
            {
                new Paper { Title = "The emergence of cinematic time", Author = Authors.First(author => author.Name.Equals("Suzanne Wilder")), ReleaseDate = new DateTime(1989, 04, 14), University = "Uppsala Universitet"}
        };
            Magazines = new List<Magazine>
            {
                new Magazine { Title = "Batman", Author = Authors.First(author => author.Name.Equals("Bill Finger")), ReleaseDate = new DateTime(1956, 03, 14), Volume = 1}
        };
            Books = new List<Book> {
            new Book { Title = "Idioten", Author = Authors.First(author => author.Name.Equals("Fjodor Dostojevskij")), Genre = Book.GenreType.Classic, Pages = 329, ReleaseDate = new DateTime(1889, 11, 23) },
            new Book { Title = "Brott och straff", Author = Authors.First(author => author.Name.Equals("Fjodor Dostojevskij")), Genre = Book.GenreType.Classic, Pages = 302, ReleaseDate = new DateTime(1878, 12, 23) },
            new Book { Title = "Krig och Fred", Author = Authors.First(author => author.Name.Equals("Leo Tolstoj")), Genre = Book.GenreType.Classic, Pages = 401, ReleaseDate = new DateTime(1865, 10, 02) }
        };

        }

        public void Print(string author)
        {
            var tempList = new List<Publication>();
            tempList.AddRange(Books);
            tempList.AddRange(Papers);
            tempList.AddRange(Magazines);
            Console.Clear();

            foreach (var book in tempList)
                if (book.Author.Name.ToLower().Equals(author.ToLower()))
                    Console.WriteLine(book.Title);
           

            Console.ReadKey();
        }

    }
}
