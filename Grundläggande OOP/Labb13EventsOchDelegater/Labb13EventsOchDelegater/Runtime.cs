using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class Runtime
    {
        private event WrongInputEventHandler WrongInput;
        Lists lists = new Lists();

        public void Start()
        {
            var adultChecker = new AdultChecker();
            var decencyAgency = new DecencyAgency();
            WrongInput += adultChecker.OnWrongInput;
            WrongInput += decencyAgency.OnWrongInput;

            do
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1:
                        AddFilm();
                        break;
                    case ConsoleKey.D2:
                        FilterFilms();
                        break;
                }
            } while (true);
        }

        public void AddFilm()
        {
            Console.WriteLine("Title");
            string input = Console.ReadLine();
            if (input.ToLower().Contains("xxx"))
                OnWrongInput(input);
            else
            {
                Film newFilm = new Film { Title = input};
                int genreInput = UI.SelectGenres();
                newFilm.Genre = (Film.GenreType)genreInput;
                Console.WriteLine("Length:");
                newFilm.Length = int.Parse(Console.ReadLine());
                lists.Films.Add(newFilm);
            }
        }

        public void FilterFilms()
        {
            Func<Film,bool> filterDrama = FilterMethods.FilterMinutes;

            switch (UI.FilterMenu())
            {
                case ConsoleKey.D1:
                    lists.PrintFilms(filterDrama);
                    break;
                case ConsoleKey.D2: lists.PrintFilms(film => film.Length > 90);
                    break;
                case ConsoleKey.D3: lists.PrintFilms(film => film.Length > 100 && film.Genre == Film.GenreType.Komedi);
                    break;
            }
        }
       
        protected virtual void OnWrongInput(string input)
        {
            if (WrongInput != null)
                WrongInput.Invoke(input);
            Console.ReadKey();
        }
    }
}
