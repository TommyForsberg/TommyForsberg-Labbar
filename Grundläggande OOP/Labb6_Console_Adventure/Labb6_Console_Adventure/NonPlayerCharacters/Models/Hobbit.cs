using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Hobbit : INonPlayerCharacter
    {
        public string  Name {get; set;}

        public int TemperPoints { get; set; }
    
        public string Appearance(string location)
        {
            return string.Format("The hobbit looked greasy");
        }

        public void Presentation()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}