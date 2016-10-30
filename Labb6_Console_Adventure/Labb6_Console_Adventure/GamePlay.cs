using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class GamePlay
    {
        bool isIntroductionToBeShown = true;
        bool IsGameRunning { get; set; }
        GamesController gamesController = new GamesController();
        public void Start()
        {
            IsGameRunning = true;
            do
            {
                InteractWithRoom();
            } while (IsGameRunning);
        }

        public void InteractWithRoom()
        {
            //Console.Clear();
            UI.Header(gamesController.FetchCurrentRoom());
            if(isIntroductionToBeShown ==true)
                {
                UI.Introduction();
                isIntroductionToBeShown = false;
            }
            else
            { UI.InitialRoomPresentation(gamesController.FetchCurrentRoom().Location); }
            
            UI.PrintStandardChoices();
            int input = ValidInput.ValidInteger();
            
                
                switch (input)
                {
                    case 1:
                    UI.Header(gamesController.FetchCurrentRoom());
                    gamesController.LookAround();
                    InteractWithSurroundings();
                        
                        break;
                    case 2:
                    UI.Header(gamesController.FetchCurrentRoom());
                    gamesController.Travel();
                    break;

                        case 3:
                    UI.Header(gamesController.FetchCurrentRoom());
                    gamesController.CheckInventory();
                    InteractWithObject();
                    break;

                case 4:
                    IsGameRunning = false;
                    break;

                }
           
        }

        public void InteractWithSurroundings()
        {
           
            bool run = true;
            do
            {
                UI.PrintInDepthChoices();
                int input = ValidInput.ValidInteger();
                switch (input)
                {
                    case 1:
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.FetchCurrentRoom().People[0].Presentation();
                        break;
                    case 2:
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.ObserveCharacter();
                        break;
                            case 3:
                        UI.Header(gamesController.FetchCurrentRoom());
                        InteractWithObject();
                        break;
                    case 4: run = false;
                        break;
                }
            } while (run);
        }

        public void InteractWithObject()
        {
            bool run = true;
            do
            {
                UI.PrintInteractWithObjectsMenu();
                int input = ValidInput.ValidInteger();
                switch (input)
                {
                    case 1:
                        break;
                    case 2:
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.LookAround();
                        run = false;
                        break;
                }
            } while (run);
        }
    }
}
