using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Apartment : IEnvironment
    {
        public string Location { get; set; }
      public bool PeopleObserved { get; set; }

        public List<INonPlayerCharacter> People { get; set; }
    

        public void Appearance()
        {

            Console.WriteLine("The room was located at " + Location);
            //if(People != null)
            //{
            //    PeopleObserved = true;
            //    Console.WriteLine("Someone was in the room with you.");
            //    int index = 1;
            //    foreach(var people in People)
            //    {
            //        Console.WriteLine(index + ". A " + people.GetType().Name + " was standing in the corner");
            //    }
               
            //}
        }
    }
}