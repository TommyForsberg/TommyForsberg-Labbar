using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class Client //Switches for maneuvering
    {
       public void Start() 
        {
            do
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        FilmChoice();
                        break;
                    case ConsoleKey.D2:
                        BookChoice();
                        break;
                }
            } while (true);
        }

        public void FilmChoice()
        {
            bool run = true;
            var filmsController = new FilmsController();
            do
            {
                UI.PrintFilmMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        filmsController.Add();
                        break;

                    case ConsoleKey.D2:
                        filmsController.Remove();
                        break;

                    case ConsoleKey.D3:
                        filmsController.PrintList();
                        break;

                    case ConsoleKey.D4:
                        filmsController.Edit();
                        break;

                    case ConsoleKey.D5:
                        run = false;
                        break;
                }
            } while (run);
        }

        public void BookChoice()
        {
            var booksController = new BooksController();
            bool run = true;
            do
            {
                UI.PrintBookMenu();
                var input = Console.ReadKey(true).Key;
                switch(input)
                {
                    case ConsoleKey.D1:
                        booksController.Add();
                        break;

                    case ConsoleKey.D2:
                        booksController.Remove();
                        break;
                    case ConsoleKey.D3:
                        booksController.PrintList();
                        break;
                    case ConsoleKey.D4:
                        booksController.Edit();
                        break;
                    case ConsoleKey.D5:
                        run = false;
                        break;
                }
            } while (run);
        }
    }
}
