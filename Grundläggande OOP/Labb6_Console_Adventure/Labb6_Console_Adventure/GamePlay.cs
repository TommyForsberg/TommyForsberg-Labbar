using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class GamePlay //All different switches for user input
    {
        public static bool isRingFound { get; set; }
        bool isIntroductionToBeShown = true;
        bool IsGameRunning { get; set; }
        GamesController gamesController = new GamesController();
        public void Start()
        {
            isRingFound = false;
            IsGameRunning = true;
            do
            {
                InteractWithRoom();
            } while (IsGameRunning);
        }

        public void InteractWithRoom()
        {
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
                    InteractWithInventory();
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
                        int index = gamesController.ObserveCharacter();
                        InteractWIthCharacter(index);
                        break;
                    case 2:
                        UI.Header(gamesController.FetchCurrentRoom());
                        bool interact = gamesController.InteractWithObjects();
                        if (interact)
                        { InteractWithObject(); }
                        break;
                            case 3:
                        run = false;
                        break;
                }
            } while (run);
        }

        public void InteractWIthCharacter(int index)
        {
            bool run = true;
            do
            {
                UI.PrintInteractWithCharacterMenu();
                int input = ValidInput.ValidInteger();
                switch (input)
                {
                    case 1:
                        gamesController.TalkToCharacter(index);
                        break;
                    case 2:
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.LookAround();
                        run = false;
                        break;
                }
            }
            while (run);
        }

        public void InteractWithInventory()
        {
            bool run = true;
            do
            {
                UI.PrintInteractWithObjectsMenu();
                int input = ValidInput.ValidInteger();
                switch (input)
                {
                    case 1:
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.ExamineObject(gamesController.FetchSherlocksInventory());
                        break;
                    case 2:
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.LookAround();
                        run = false;
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
                        UI.Header(gamesController.FetchCurrentRoom());
                        gamesController.ExamineObject(gamesController.FetchCurrentRoom().Furniture.ToArray());
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
