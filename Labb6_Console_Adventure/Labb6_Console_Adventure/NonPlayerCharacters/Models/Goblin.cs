using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Goblin : INonPlayerCharacter
    {
        public string Name { get; set; }

        public string SignatureMark { get; set; }

        public string  Race {get; set;}
      

        public int TemperPoints { get; set; }


        public void Appearance()
        { }

        public void Presentation()
        {
            
        }
    }
}