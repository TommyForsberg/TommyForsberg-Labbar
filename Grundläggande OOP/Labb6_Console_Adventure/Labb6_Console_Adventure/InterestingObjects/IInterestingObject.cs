using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public interface IInterestingObject
    {
        bool Interactable { get; set; }
        string Color { get; set; }
        string Clue { get;}
        string Appearance();
    }
}