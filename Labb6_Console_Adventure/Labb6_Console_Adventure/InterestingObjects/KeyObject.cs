using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class KeyObject : IInterestingObject
    {
        public string Clue
        {
            get
            {
                GamePlay.isRingFound = true;
                return string.Format("It looked very interesting, could it be??\n I better get back to Baker Street!");
            }
        }

        public string Color
        {
            get; set;
        }

        public bool Interactable
        {
            get; set;
        }
        public enum KeyObjectType
        {
            Ring,
            Axe
        }
        public KeyObjectType ObjectType { get; set; }

        public string Appearance()
        {
            return string.Format(ObjectType.ToString());
        }
    }
}