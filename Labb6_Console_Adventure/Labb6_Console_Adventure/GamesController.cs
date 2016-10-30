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
            //UI.CurrentRoom = repository.Rooms[0];
        }
        public void LookAround()
        {
            //UI.CurrentRoom.Appearance();
            repository.CurrentRoom.Appearance();
            UI.PrintInitialPeopleStatus(FetchCurrentRoom());
            UI.PrintInitialFurnituringStatus(FetchCurrentRoom());
        }

        public IEnvironment FetchCurrentRoom()
        {
            return repository.CurrentRoom;
        }

        public void Travel()
        {

            UI.PrintLocations(repository.Rooms);
            int index = UI.SetCurrentRoom()-1;
            repository.CurrentRoom = repository.Rooms[index];
        }

        public void ObserveCharacter()
       {
            if(repository.CurrentRoom.People == null)
            {
                Console.WriteLine("There was no one there..");
            }
           else if (FetchCurrentRoom().People.Count == 1)
            {
                Console.WriteLine(repository.CurrentRoom.People[0].Appearance(FetchCurrentRoom().Location));
            }
            else
            {
                UI.PrintCharacters(repository.CurrentRoom);
                int index = UI.ChooseNumberForInteraction();
                repository.CurrentRoom.People[index].Presentation();
            }
        }

        public void CheckInventory()
        {
             
            

           UI.PrintObjects(repository.SherlocksStuff.ToArray());
            
            //UI.PrintObjects(repository.CurrentRoom.Furniture.ToArray());
        }
        
    }
}
