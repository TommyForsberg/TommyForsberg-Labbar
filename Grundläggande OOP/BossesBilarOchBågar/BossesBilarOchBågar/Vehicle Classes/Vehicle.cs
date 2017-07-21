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
        public string StockCode { get; set; }

        public virtual string PrintVehicle() //Prints all vehicles in the same format
        {
            return String.Format("{0,-10}{1,-10}{2,-10}{3,-10}{4, -10}{5, -10}{6, -5}",StockCode, Brand, Model, Year, Color, Used == true ? "Used" : "New", Price);
        }
    }
}