using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class Lists
    {
        public List<Film> Films { get; set; }
        public Lists()
        {
            Films = new List<Film>
            {
                new Film { Title = "A clockwork Orange", Genre = Film.GenreType.Drama, Length = 143 },
                new Film { Title = "Bad Santa", Genre = Film.GenreType.Komedi, Length = 98 },
                new Film { Title = "En underbar jävla jul", Genre = Film.GenreType.Drama, Length = 101 },
                new Film { Title = "Juloratoriet", Genre = Film.GenreType.Drama, Length = 150 },
                new Film { Title = "Ensam Hemma 2", Genre = Film.GenreType.Komedi, Length = 87 },
                new Film { Title = "Life of Brian", Genre = Film.GenreType.Komedi, Length = 102 },
                new Film { Title = "Die Hard 2", Genre = Film.GenreType.Action, Length = 98 },
                new Film { Title = "Elf", Genre = Film.GenreType.Komedi, Length = 95 },
                new Film { Title = "Jesus of Nazareth", Genre = Film.GenreType.Drama, Length = 164 },
                new Film {Title = "Ben Hur", Genre = Film.GenreType.Action, Length = 180 }
            };
        }

        public void PrintFilms(FilteringOptions filter)
        {
            Console.Clear();
            foreach(var film in Films)
                if(filter(film))
                    Console.WriteLine("{0,-25}{1,-10}{2}", film.Title, film.Genre, film.Length);

            Console.ReadLine();
        }

      
    }
}
