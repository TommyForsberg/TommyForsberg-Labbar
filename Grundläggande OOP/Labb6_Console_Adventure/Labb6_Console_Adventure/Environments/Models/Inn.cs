using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Inn : IEnvironment
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public List<INonPlayerCharacter> People { get; set; }
        public List<IInterestingObject> Furniture { get; set; }
        public void Appearance()
        {
            Console.WriteLine("Shadows of " + Location + " had a grip on the smelly bar.");
        }
       
    }
}