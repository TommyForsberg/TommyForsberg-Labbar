using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLektion.Interfaces
{
    class Plane : IFlyable
    {
        public int TopSpeed { get; set; }
        public void  Fly()
        {
            Console.WriteLine("swoosh");
        }
    }
}
