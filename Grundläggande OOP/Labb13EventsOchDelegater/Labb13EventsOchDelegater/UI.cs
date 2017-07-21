using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class UI
    {
        public static ConsoleKey MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add film");
            Console.WriteLine("2. Filter films");
           ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }

        public static ConsoleKey FilterMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Show all drama");
            Console.WriteLine("2. Show all film over 90 min");
            Console.WriteLine("3. Show all Comedy over 100 min");
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static int SelectGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Film.GenreType)))
            {
                Console.WriteLine(genre);
            }

            Console.WriteLine("Select Genre:");
            return int.Parse(Console.ReadLine());
        }
    }
}
