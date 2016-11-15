using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12_Linq
{
    class Repository
    {
        public List<Film> Films { get; set; }

        public Repository()
        {
            Films = new List<Film>
            {
                new Film { Title = "A clockwork Orange", Genre = Film.GenreType.Drama, Length = 143 },
                new Film { Title = "Bad Santa", Genre = Film.GenreType.Komedi, Length = 98 },
                new Film { Title = "En underbar jävla jul", Genre = Film.GenreType.Drama, Length = 101 },
                new Film { Title = "Juloratoriet", Genre = Film.GenreType.Drama, Length = 150 },
                new Film { Title = "Ensam Hemma 2", Genre = Film.GenreType.Komedi, Length = 87 },
                new Film { Title = "Die Hard 2", Genre = Film.GenreType.Action, Length = 98 },
                new Film { Title = "Elf", Genre = Film.GenreType.Komedi, Length = 95 },
                new Film { Title = "Jesus of Nazareth", Genre = Film.GenreType.Drama, Length = 164 }
            };
        }

        public Film[] GetFilmsByGenre()
        {
            int index = 1;
            foreach (var genre in Enum.GetValues(typeof(Film.GenreType)))
            {
                Console.WriteLine(index + " " + genre);
                index++;
            }

            Console.WriteLine("Choose genre:");
            int input = int.Parse(Console.ReadLine());
            var selectedFilms = Films.Where(film => film.Genre == (Film.GenreType)input).ToArray();
            return selectedFilms;
        }
            

        public Film GetFilmByTitle(string Title)
        {
            var selectedFilm = Films.SingleOrDefault(film => film.Title.ToLower() == Title.ToLower());
            return selectedFilm != null ? selectedFilm : null;
        }
        public Film[] GetFilmsByLength()
        {
            var selectedFilms = Films.Where(film => film.Length < 120).ToArray();
            return selectedFilms;
        }

        public string[] GetStringArray()
        {
            var selectedFilms = Films.Select(film => film.Title).ToArray();
            return selectedFilms;
        }

        public string GetFilmTitle(string Title)
        {
            string filmTitle = Films.Where(film => film.Title.ToUpper().Equals(Title.ToUpper())).Select(film => film.Title).SingleOrDefault();
            return filmTitle!= null ? filmTitle : null;
        }
        public Film[] SpecialFilter()
        {
            var selectedFilms = Films.Where(film => film.Title[0].Equals('E') && film.Length > 90 && film.Genre.Equals(Film.GenreType.Drama)).ToArray();
            return selectedFilms;
        }
    }
}
