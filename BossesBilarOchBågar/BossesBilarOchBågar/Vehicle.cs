using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BossesBilarOchBågar
{
    public abstract class Vehicle
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Used { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public virtual string PrintVehicle()
        {
            return String.Format("{0,-10}{1,-10}{2,-10}{3,-10}{4, -10}{5, -10}", Brand, Model, Year, Color, Used == true ? "Used" : "New", Price);
            // return  String.Format("{0}{1,10}{2,10}{3,10}{4, 10}{5, 10}", Brand, Model, Year, Color, Used == true ?"Used" : "New", Price );

        }
        

    }
}