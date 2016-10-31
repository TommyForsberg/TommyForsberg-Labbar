using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class UI
    {
        public static void Introduction()
        {
            Console.WriteLine("Hi, your name is Sherlock Holmes. You have been sent \nto another dimension to find a certain ring...");
        }

        public static void PrintStandardChoices()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Look at Map/Travel");
            Console.WriteLine("3. Show inventory");
            Console.WriteLine("4. Exit");
        }

        public static void PrintInDepthChoices()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("1. Interact with person");
            Console.WriteLine("2. Interact with object");
            Console.WriteLine("3. Return");
        }

        public static void Header(IEnvironment CurrentRoom)
        {
            Console.Clear();
            Console.WriteLine("{0}{1,20}{2,15}"+ Environment.NewLine,"Sherlock Holmes in Middle Earth|","Current Room:",CurrentRoom.Location);
        }

        public static int SetCurrentRoom()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Where do you want to go Sherlock?");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintLocations(List<IEnvironment> locations)
        {
            int index = 1;
            foreach(var location in locations)
            {
                Console.WriteLine(index + ". " +location.Name +", " +location.Location);
                index++;
            }
        } 
        public static void PrintCharacters(IEnvironment currentRoom)
        {
            int index = 1;
            foreach(var person in currentRoom.People)
            {
                Console.WriteLine(index + ". A " + person.GetType().Name);
                index++;
            }
        }
        public static void PrintInitialPeopleStatus(IEnvironment currentRoom)
        {
            if (currentRoom.People == null)
            {
                Console.WriteLine("You were alone.");
            }
            else if (currentRoom.People.Count == 1)
            {
                Console.WriteLine("a person stood alone in the " + currentRoom.GetType().Name +" with you.");
            }
            else if (currentRoom.People.Count > 2)
            {
                Console.WriteLine("The "+ currentRoom.GetType().Name + " was crowded." );
            }
        }

        public static void PrintInitialFurnituringStatus(IEnvironment currentRoom)
        {
            if (currentRoom.Furniture.Count < 1)
            {
                Console.WriteLine("The furniture wasn't exciting..");
            }
            else
            {
                Console.WriteLine("It looked like the surroundings might hold some secrets.");
            }
        }

        public static int ChooseNumberForInteraction()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Pick the corresponding number:");
            return ValidInput.ValidInteger();
        }
        public static void InitialRoomPresentation(string currentLocation)
        {
            Console.WriteLine("Welcome to " + currentLocation+".");

            if (GamePlay.isRingFound == true && currentLocation == "Baker Street")
            {

                Console.WriteLine("You investigated the ring in a microscope. Clearly You had found it!");
                Console.WriteLine("YOU WON THE GAME!");
            }
        }

        public static void PrintObjects(IInterestingObject[] objects)
        {
                int index = 1;
                foreach (var thing in objects)
                {
                    Console.WriteLine(index + ". A " + thing.Appearance());
                    index++;
                }
        }
        public static void PrintInventory(IInterestingObject[] objects)
        {
            Console.WriteLine("Your inventory included:");
            Console.WriteLine();
            PrintObjects(objects);
        }

        public static void PrintInteractWithObjectsMenu()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("1. Examine");
            Console.WriteLine("2. Return");
        }

        public static void PrintInteractWithCharacterMenu()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("1. Talk to");
            Console.WriteLine("2. Return");
        }
    }
}
