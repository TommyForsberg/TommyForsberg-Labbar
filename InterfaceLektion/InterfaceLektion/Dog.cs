using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLektion
{
    class Dog :ISpeakable
    {
        public string Speak()
        {
            return "woof woof";
        }
    }
}
