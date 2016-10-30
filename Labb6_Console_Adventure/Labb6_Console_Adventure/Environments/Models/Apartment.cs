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
        public List<IInterestingObject> Furniture { get; set; }
    

        public void Appearance()
        {
            Console.WriteLine("The room was located at " + Location + ",");
        }
    }
}