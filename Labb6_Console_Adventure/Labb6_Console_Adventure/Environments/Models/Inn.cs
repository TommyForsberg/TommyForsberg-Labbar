using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Inn : IEnvironment
    {
        public string Location { get; set; }
        

        public List<INonPlayerCharacter> People { get; set; }

        public bool PeopleObserved { get; set; }


        public void Appearance()
        { }
       
    }
}