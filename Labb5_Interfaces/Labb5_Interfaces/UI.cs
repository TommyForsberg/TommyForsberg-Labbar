using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add film");
            Console.WriteLine("2. Remove film");
            Console.WriteLine("3. Show all films");
            Console.WriteLine("4. Edit film");
            Console.WriteLine("5. Return");
        }

        public static Film AddFilm()
        {
            Film newFilm = new Film();
            Console.WriteLine("Film title:");
            newFilm.Title = Console.ReadLine();
            return newFilm;
        }

        public static void PrintFilms(Item[] films)
        {
            foreach(var film in films)
            {
                Console.WriteLine("{0}", film.Title);
            }
        }

        public static int SelectFilm(Item[] films)
        {
            PrintFilms(films);
            Console.Write("Select film:");
            return int.Parse(Console.ReadLine());
        }

        public static void EditFilm(Item film)
        {
            
            
            
            Console.Clear();
            Console.WriteLine("1. Change title");
            Console.WriteLine("2 Change genre");
            Console.WriteLine("3. Change director");

            Console.WriteLine(film.Title);
            var choice = Console.ReadKey(true).Key;
            switch(choice)
            {
                case ConsoleKey.D1:
                    break;
            }
            
        }

    }
}
