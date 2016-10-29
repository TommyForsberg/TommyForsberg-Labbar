using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class GamesController
    {
        
        Repository repository = new Repository();

       public GamesController()
        {
            UI.CurrentRoom = repository.Rooms[0];
        }
        public void LookAround()
        {
            UI.CurrentRoom.Appearance();

          
        }

        public void FetchCurrentRoom()
        {

        }

        public void Travel()
        {

            UI.PrintLocations(repository.Rooms);
            // UI.PrintLocations(repository.GetAllRooms());
            int index = UI.SetCurrentRoom()-1;
            UI.CurrentRoom = repository.Rooms[index];
            Console.WriteLine(UI.CurrentRoom.Location);
            Console.ReadKey(true);
        }
        
    }
}
