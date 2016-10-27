using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLektion.Interfaces
{
    //The class that implements the inteface defines _how_ things are done,
    //how they look, behave, etc. In other words; This is where we fill the
    //methods with code.
    class Bird : IFlyable, ISpeakable

    {
        public int TopSpeed { get; set; }
        public string Color { get; set; }
        public void Fly()
        {
            Console.WriteLine("Flap flap");
        }

        public string Speak()
        {
            return "tweet";
        }
    }
}
