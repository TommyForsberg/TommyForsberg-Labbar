using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class BooksController : IController
    {
        private IRepository repository = new BookRepository();

        public void PrintList() //Book object is created here
        {
            Console.Clear();
            UI.PrintItems(repository.GetItems());
            Console.ReadKey(true);
        }

        public void Add()
        {
            Book newBook = new Book();
            UI.AddItem(newBook);
            repository.AddItem(newBook);
        }

        public void Remove()
        {
            var books = repository.GetItems();
            var selectedBook = UI.SelectItem(books) - 1;
            repository.RemoveItem(books[selectedBook]);
        }

        public void Edit()
        {
            Console.Clear();
            var films = repository.GetItems();
            var selectedFilm = UI.SelectItem(films) - 1;

            UI.EditItem(films[selectedFilm]);
        }
    }
}
