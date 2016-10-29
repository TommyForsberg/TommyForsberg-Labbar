using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Console_Adventure
{
    class UI
    {
       public static IEnvironment CurrentRoom { get; set; }

      
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
            Console.WriteLine("4. Interact");
        }

        public static void PrintCharacterChoices()
        {
            
            Console.WriteLine("1. Talk to");
            Console.WriteLine("2. Look at");
        }

        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("{0}{1,20}{2,15}"+ Environment.NewLine,"Sherlock Holmes in Middle Earth|","Current Room:",CurrentRoom.Location);
        }

        public static int SetCurrentRoom()
        {
            
            Console.WriteLine("Where do you want to go Sherlock?");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintLocations(List<IEnvironment> locations)
        {
            int index = 1;
            foreach(var location in locations)
            {
                Console.WriteLine(index + " " + location.Location);
                index++;
            }
        } 
        public static void PrintCharacters()
        {
            int index = 1;
            foreach(var person in CurrentRoom.People)
            {
                Console.WriteLine(index + ". A " + person.GetType().Name + " was standing in the corner");
                index++;
            }
        }


    }
}
