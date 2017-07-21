using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BossesBilarOchBågar
{
    public class Car : Vehicle
    {
        public override string PrintVehicle() //Overrides method for specific string
        {
            return string.Format("{0,-10}{1}", "Car", base.PrintVehicle());
        }
        public string GenerateStockCode() //generates code when adding to stock
        {
            return string.Format("{0}{1}", "C", (VehicleHandler.Cars.Count + 1).ToString("D3"));
        }

    }


}