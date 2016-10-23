using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BossesBilarOchBågar
{
    public class MotorCycle : Vehicle
    {

        public override string PrintVehicle() //overrides method for object specific string
        {
            return string.Format("{0,-10}{1}", "MC", base.PrintVehicle()); 
        }

        public string GenerateStockCode() //Generates stock number
        {
            return string.Format("{0}{1}", "MC", VehicleHandler.MotorCycles.Count + 1.ToString("D3"));
        }
    }
}