using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Prop :IInterestingObject
    {
        public string Clue
        {
            get
            {
                return String.Format("There was nothing interesting about it.");
            }

        }

        public string Color { get; set; }
        public enum PropType
        {
            Napkin,
            Violin,
        }
        public PropType ObjectType { get; set; }


        public bool Interactable
        {
            get
            {
                return Interactable;
            }

            set
            {
                Interactable = false;
                
            }
        }

        public string Appearance()
        {
            return string.Format(ObjectType.ToString());
        }
    }
}