using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16InterfaceRepository
{
   
    
    class Runtime
    {
        Manager manager = new Manager();
        public void Start()
        {
            manager.FileUpdate += manager.FileUpdateData;

            while (true)
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1:
                        manager.ChangeProductInList();
                        break;
                    case ConsoleKey.D2:
                        manager.RemoveProductInList();
                        break;

                    case ConsoleKey.D3:
                        manager.AddProductToList();
                        break;
                    case ConsoleKey.D4:
                        manager.ChangeProductInFile();
                        break;
                    case ConsoleKey.D5:
                        manager.RemoveProductInFile();
                        break;
                    case ConsoleKey.D6:
                        manager.AddProductToFile();
                        break;
                }
            }
        }
       


    }
}
