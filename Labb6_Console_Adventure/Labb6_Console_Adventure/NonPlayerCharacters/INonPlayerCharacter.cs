using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public interface INonPlayerCharacter
    {
        int TemperPoints { get; set; }
        string Name { get; set; }
        string Race { get; set; }


        void Presentation();
        string Appearance(string location);
    }

}