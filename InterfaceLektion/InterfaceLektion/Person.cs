using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLektion
{
    class Person :ISpeakable
    {
        public string Speak()
        {
            return "hello";
        }
    }
}
