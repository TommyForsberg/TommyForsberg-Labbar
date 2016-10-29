using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Human : INonPlayerCharacter
    {
        public string Name { get; set; }
  
        public string Race { get; set; }
        public string FacialHair { get; set; }
        public enum SkinType
        {
            Pale,
            Cold,
            Raw
        }
        public SkinType Skin
        {
            get { return Skin; }
            set { if (UI.CurrentRoom.Location == "Baker Street")
                 Skin = 0;
            } 
        }

        public int TemperPoints { get; set; }


        public void Appearance()
        {
            string.Format("The human looked {0} as always in {1}",Skin,UI.CurrentRoom.Location);
                
            
        }




        public void Presentation()
        {
            Console.WriteLine("Hello, my name is" + Name);
        }
    }
}