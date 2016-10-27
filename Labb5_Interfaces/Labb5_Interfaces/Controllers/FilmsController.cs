using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class FilmsController : IController
    {
        private IRepository repository = new FilmRepository();

        public void Add() //Film object is created here
        {
            Film newFilm = new Film();
            UI.AddItem(newFilm);
            repository.AddItem(newFilm);
        }

        public void Remove()
        {
            var films = repository.GetItems();
            var selectedFilm = UI.SelectItem(films) -1;
            repository.RemoveItem(films[selectedFilm]);
        }

        public void PrintList()
        {
            Console.Clear();
            UI.PrintItems(repository.GetItems());
            Console.ReadKey(true);
        }

        public void Edit()
        {
            Console.Clear();
            var films = repository.GetItems();
            var selectedFilm = UI.SelectItem(films) -1;
            UI.EditItem(films[selectedFilm]);
        }
    }
}
