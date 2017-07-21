using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Human : INonPlayerCharacter
    {
        public string Name { get; set; }
       
        public string FacialHair { get; set; }
        public enum SkinType
        {
            Pale,
            Cold,
            Raw,
            flawless
        }
        public SkinType Skin
        {
            get; set;
        }

        public int TemperPoints { get; set; }

        public Human(string location)
        {
            if (location == "Gondor")
            {
                Skin = 0;
                if (TemperPoints > 6)
                {
                    TemperPoints-=2;
                }
            }
            else
            {
                Skin = (SkinType)3;
            }
        }
        public string Appearance(string location)
        {
                return string.Format("The human looked {0} as always in {1}, his {2} looked very tastefull.",
                Skin, location, FacialHair);
            }
        public void Presentation()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}