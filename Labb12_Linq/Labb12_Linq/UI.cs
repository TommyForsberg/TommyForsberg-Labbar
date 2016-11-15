using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12_Linq
{
    class UI
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Hämta en film med ett specifikt namn");
            Console.WriteLine("2. Hämta alla filmer ur en genre");
            Console.WriteLine("3. Hämta alla filmer med en speltid under 120 minuter");
            Console.WriteLine("4. Skapa en string-array med alla filmers namn");
            Console.WriteLine("5. Spara en specifik films namn i en string-variabel" );
            Console.WriteLine("6. Hämta alla filmer vars namn börjar på 'E' och har en speltid över 90 minuter och hör till Komedi.");
        }

        public static string InputTitle()
        {
            Console.WriteLine("Title:");
            return Console.ReadLine();
        }

        public static void PrintFilms(Film[] films)
        {
            foreach (var film in films)
                Console.WriteLine(film.PrintFormat());
        }

        public static void PrintFilms(string[] films)
        {
            foreach (var film in films)
                Console.WriteLine(film);
        }

        public static void PrintFilms(Film film)
        {
            Console.WriteLine(film != null ? film.PrintFormat() : "Film not found");
        }
        public static void PrintFilms(string film)
        {
            Console.WriteLine(film != null ? film : "Film not found");
        }
    }
}
