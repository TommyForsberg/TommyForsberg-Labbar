using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class FilmsController
    {
        private IRepository repository = new FilmRepository();

        public void AddFilm()
        {
            var newFilm = UI.AddFilm();
            repository.AddItem(newFilm);
        }

        public void RemoveFilm()
        {
            var films = repository.GetItems();
            var selectedFilm = UI.SelectFilm(films) -1;
            repository.RemoveItem(films[selectedFilm]);
        }

        public void PrintFilmList()
        {
            Console.Clear();
            UI.PrintFilms(repository.GetItems());
            Console.ReadKey(true);
        }

        public void EditFilm()
        {
            Console.Clear();
            var films = repository.GetItems();
            var selectedFilm = UI.SelectFilm(films) -1;

            UI.EditFilm(films[selectedFilm]);
        }
    }
}
