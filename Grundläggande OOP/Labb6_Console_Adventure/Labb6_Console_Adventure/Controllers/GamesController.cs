using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class GamesController //Bridge between GamePlay Repository and UI
    {

        Repository repository = new Repository();
        public void LookAround()
        {
            repository.CurrentRoom.Appearance();
            UI.PrintInitialPeopleStatus(FetchCurrentRoom());
            UI.PrintInitialFurnituringStatus(FetchCurrentRoom());
        }

        public IEnvironment FetchCurrentRoom()
        {
            return repository.CurrentRoom;
        }

        public IInterestingObject[] FetchSherlocksInventory()
        {
            return repository.SherlocksStuff.ToArray();
        }

        public void Travel()
        {
            UI.PrintLocations(Repository.Rooms);
            int index = UI.SetCurrentRoom() - 1;
            repository.CurrentRoom = Repository.Rooms[index];
        }

        public int ObserveCharacter()
        {
            if (repository.CurrentRoom.People == null)
            {
                Console.WriteLine("There was no one there..");
                return 0;
            }
            else if (FetchCurrentRoom().People.Count == 1)
            {
                Console.WriteLine(repository.CurrentRoom.People[0].Appearance(FetchCurrentRoom().Location));
                return 0;
            }
            else
            {
                UI.PrintCharacters(repository.CurrentRoom);
                int index = UI.ChooseNumberForInteraction() -1;
                UI.Header(FetchCurrentRoom());
                Console.WriteLine(repository.CurrentRoom.People[index].Appearance(repository.CurrentRoom.Location));
                return index;
            }
        }

        public void CheckInventory()
        {
            UI.PrintInventory(repository.SherlocksStuff.ToArray());
        }

        public bool InteractWithObjects()
        {
            if (repository.CurrentRoom.Furniture.Count < 1)
            { Console.WriteLine("There was nothing to examine but dust..");
                return false; ;
            }
            UI.PrintObjects(repository.CurrentRoom.Furniture.ToArray());
            return true;
        }
        public void ExamineObject(IInterestingObject[] objects)
        {
            if(objects.Length < 0)
            {
                Console.WriteLine("There was nothing to examine..");
            }
         
            else if (objects.Length == 1)
            {
                Console.WriteLine(objects[0].Clue);

                if (objects[0].Interactable == true)
                {
                    Console.WriteLine("You picked it up");
                    repository.CurrentRoom.Furniture[0].Interactable = false;
                    repository.SherlocksStuff.Add(repository.CurrentRoom.Furniture[0]);
                    FetchCurrentRoom().Furniture.RemoveAt(0);
                }
            }
            else if(objects.Length > 1)
            {
                UI.PrintObjects(objects);
                int index = UI.ChooseNumberForInteraction() - 1;
                UI.Header(FetchCurrentRoom());
                Console.WriteLine(objects[index].Clue);
                if (objects[index].Interactable == true)
                {
                    Console.WriteLine("You picked it up");
                    repository.CurrentRoom.Furniture[index].Interactable = false;
                    repository.SherlocksStuff.Add(repository.CurrentRoom.Furniture[index]);
                    FetchCurrentRoom().Furniture.RemoveAt(index);
                }
            }
        }

        public void TalkToCharacter(int index)
        {
            UI.Header(FetchCurrentRoom());
            if (repository.CurrentRoom.People != null)
            repository.CurrentRoom.People[index].Presentation();

            else
            { Console.WriteLine("You were all alone"); }
        }

        public void AddEnvironment(IEnvironment newRoom)
        {
            Repository.Rooms.Add(newRoom);
        }
    }
}
