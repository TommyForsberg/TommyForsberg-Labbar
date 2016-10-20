using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BossesBilarOchBågar
{
    public class Car : Vehicle
    {
        public override string PrintVehicle()
        {
            return string.Format("{0,-10}{1}", "Car", base.PrintVehicle());
        }

       
    }


}