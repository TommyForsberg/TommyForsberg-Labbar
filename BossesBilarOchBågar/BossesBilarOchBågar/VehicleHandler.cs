using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class VehicleHandler
    {
        public List<MotorCycle> MotorCycles { get; set; }
        public List<Car> Cars { get; set; }
        
        public VehicleHandler()
        {
             Cars = new List<Car>
            {
                new Car {Brand ="Volvo", Model = "740", Used = true, Color ="Blue", Year = 1988, Price = 5000  },
                new Car {Brand ="Volvo", Model = "S9000", Used = false, Color ="Blue", Year = 2016, Price = 500000  },
                new Car {Brand ="SAAB", Model = "900", Used = true, Color ="Brown", Year = 1986, Price = 4000  },
                new Car {Brand ="Volvo", Model = "V70", Used = true, Color ="Red", Year = 2010, Price = 49000  },
                new Car {Brand ="SAAB", Model = "740", Used = true, Color ="Green", Year = 1988, Price = 4800  },
                new Car {Brand ="Mercedes", Model = "X230", Used = true, Color ="Silver", Year = 1999, Price = 16000  }


            };
        }

        public void VehicleManager(List<Vehicle> selectedVehicles)
        {
            
            foreach(var vehicle in selectedVehicles)
            {
                
                Console.WriteLine(vehicle.PrintVehicle()); 
            }
            Menu.PrintFilterChoice();
            
           
        }

        public void VehicleFiltering(string color)
        {
            var selectedVehicle = new List<Vehicle>();
            selectedVehicle.AddRange(Cars);

            Vehicle[] subset = selectedVehicle
                .Where(Vehicle => Vehicle.Color.ToUpper() == color.ToUpper())
                .ToArray();

            if (subset.Length == 0)
            {
                Console.WriteLine("Hittade inget");
                Console.ReadLine();
            }
            foreach(var vehicle in subset)
            {
                Console.WriteLine(vehicle.PrintVehicle());
            }
            Console.Read();
        }
    }
}
