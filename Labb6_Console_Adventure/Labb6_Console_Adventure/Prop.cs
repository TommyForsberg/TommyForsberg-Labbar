using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Prop : IInterestingObject
    {
        public string Clue
        {
            get
            {
                return String.Format("There was nothing of interest");
            }

            set
            {
                
            }
        }

        public string Color
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Interactable
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Appearance()
        {
            throw new NotImplementedException();
        }
    }
}