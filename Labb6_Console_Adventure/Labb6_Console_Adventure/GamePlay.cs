using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class GamePlay
    {
        GamesController gamesController = new GamesController();
        public void Start()
        {

            UI.Header();
            UI.Introduction();

            do
            {
                
                InteractWithRoom();
            } while (true);
        }

        public void InteractWithRoom()
        {
            UI.PrintStandardChoices();
            //var gamesController = new GamesController();
            //int input = int.Parse(Console.ReadLine());
            int input = ValidInput.ValidInteger();
            
                
                switch (input)
                {
                    case 1:
                    UI.Header();
                    gamesController.LookAround();
                        
                        break;
                    case 2:
                    UI.Header();
                    gamesController.Travel();
                    break;

                        case 3:UI.CurrentRoom.People[0].Presentation();
                    break;

                case 4:
                    UI.Header();
                    if (UI.CurrentRoom.People == null /*|| UI.CurrentRoom.PeopleObserved == false*/)
                    { Console.WriteLine("There was no one there but you.."); }

                else
                    {
                        InteractWithCharacter();
                    }
                        break;
                }
            
        }

        public void InteractWithCharacter()
        {
            
            UI.PrintCharacters();
            UI.PrintCharacterChoices();
            int input = ValidInput.ValidInteger();
            switch(input)
            {
                case 1: 
                    break;
            }
            
        }
    }
}
