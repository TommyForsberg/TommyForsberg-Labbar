using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class Client
    {
       public void Start()
        {
            var filmsController = new FilmsController();
            do
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        filmsController.AddFilm();
                        break;

                    case ConsoleKey.D2:
                        filmsController.RemoveFilm();
                        break;

                    case ConsoleKey.D3:
                        filmsController.PrintFilmList();
                        break;

                    case ConsoleKey.D4:
                        filmsController.EditFilm();
                        break;
                }
            } while (true);
        }
    }
}
