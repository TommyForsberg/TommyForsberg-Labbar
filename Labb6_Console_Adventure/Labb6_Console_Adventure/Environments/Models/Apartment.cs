using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Apartment : IEnvironment
    {
        public string Location { get; set; }
        public string Name { get; set; }
        private List<IInterestingObject> furniture;
        public List<INonPlayerCharacter> People { get; set; }
        public List<IInterestingObject> Furniture
        {
            get
            {
                if (furniture == null)
                    furniture = new List<IInterestingObject>();

                return furniture;
            }
            set
            {
                furniture = value;
            }
        }
   public void Appearance()
        {
            Console.WriteLine("The room was located at " + Location + ",");
        }
    }
}