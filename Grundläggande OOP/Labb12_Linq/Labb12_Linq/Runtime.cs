using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12_Linq
{
    
    class Runtime
    {
        
        public void Start()
        {
            
            var repository = new Repository();
            
            do
            {
                UI.MainMenu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        UI.PrintFilms(repository.GetFilmByTitle(UI.InputTitle()));
                        break;
                    case 2:
                        UI.PrintFilms(repository.GetFilmsByGenre());
                        break;
                    case 3:
                        UI.PrintFilms(repository.GetFilmsByLength());
                        break;
                    case 4:
                        UI.PrintFilms(repository.GetStringArray());
                        break;
                    case 5:
                        UI.PrintFilms(repository.GetFilmTitle(UI.InputTitle()));
                        break;
                    case 6:
                        UI.PrintFilms(repository.SpecialFilter());
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            } while (true);
            

            

            

        }
    }
}
