using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public interface IEnvironment
    {
        string Location { get; set; }
        string Name { get; set; }
        List<INonPlayerCharacter> People { get; set; }
        List<IInterestingObject> Furniture { get; set; }
        void Appearance();
    }
}