using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class VehicleHandler //Most of the vital Code
    {
        public  static List<MotorCycle> MotorCycles { get; set; } //Lists are static to no be rewritten upon new instances of vehiclehandler.
        public static List<Car> Cars { get; set; }
        
         static VehicleHandler() //Constructor made static to be run only once.
        {
             Cars = new List<Car>
            {
                new Car {Brand ="Volvo", Model = "740", Used = true, Color ="Blue", Year = 1988, Price = 5000, StockCode = "C001"  },
                new Car {Brand ="Volvo", Model = "S9000", Used = false, Color ="Blue", Year = 2016, Price = 500000, StockCode ="C002"  },
                new Car {Brand ="SAAB", Model = "900", Used = true, Color ="Brown", Year = 1986, Price = 4000, StockCode ="C003"   },
                new Car {Brand ="Volvo", Model = "V70", Used = true, Color ="Red", Year = 2010, Price = 49000, StockCode ="C004"   },
                new Car {Brand ="SAAB", Model = "740", Used = true, Color ="Green", Year = 1988, Price = 4800, StockCode ="C005"   },
                new Car {Brand ="Mercedes", Model = "X230", Used = true, Color ="Silver", Year = 1999, Price = 16000, StockCode ="C006"   }
            };

            MotorCycles = new List<MotorCycle>
            {
                new MotorCycle {Brand ="Zuzuki", Model = "1000", Used = true, Color ="Black", Year = 1970, Price = 9000, StockCode ="MC002"   },
                new MotorCycle {Brand ="Kawazaki", Model = "X2500", Used = true, Color ="Black", Year = 1988, Price = 10000, StockCode ="MC003"   },
                new MotorCycle {Brand ="Kawazaki", Model = "X9K", Used = false, Color ="Red", Year = 2015, Price = 55000, StockCode ="MC004"   },
                new MotorCycle {Brand ="Honda", Model = "MB200", Used = false, Color ="Red", Year = 2015, Price = 59000, StockCode ="MC005"  },
                new MotorCycle {Brand ="Honda", Model = "MB200", Used = false, Color ="Red", Year = 2015, Price = 59000, StockCode ="MC006"  },
            };
        }

        public void VehicleListing(List<Vehicle> selectedVehicles) //Prints selected vehicles
        {
            foreach(var vehicle in selectedVehicles)
            {
                Console.WriteLine(vehicle.PrintVehicle()); 
            }
        }

        public void ScrapOrSellVehicle(string stockNumber, List<Vehicle> selectedStock) //Removes object from stock/list
        {
            Vehicle vehicleTobeSold = selectedStock.SingleOrDefault(vehicle => vehicle.StockCode == stockNumber); //Selects vehicle by stock code/user input
            if(vehicleTobeSold != null) //As long as the vehicle is in stock
            {
                selectedStock.Remove(vehicleTobeSold); //Removes "only for show" in temporary list to user

                if (vehicleTobeSold is Car) //Removes Car from current stock list
                {
                    Car newCar = (Car)vehicleTobeSold;
                    Cars.Remove(newCar); }
                if(vehicleTobeSold is MotorCycle) //Removes Motorcycle from current stock list
                {
                    MotorCycle newMotorCycle = (MotorCycle)vehicleTobeSold;
                    MotorCycles.Remove(newMotorCycle); }
                Console.WriteLine("Removed" + selectedStock);
            }
            else
            { Console.WriteLine("Not Found"); }
        }

        public void AddToStock(Vehicle newVehicle) //Adds new vehicle
        {
            Console.WriteLine("What is the brand?");
            newVehicle.Brand = Console.ReadLine();
            Console.WriteLine("What is the model?");
            newVehicle.Model = Console.ReadLine();
            Console.WriteLine("What is the color");
            newVehicle.Color = Console.ReadLine();
            Console.WriteLine("What is the year?");
            newVehicle.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("What price?");
            newVehicle.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the vehicle new? (YES/NO)");
            string newVehicleUsed = Console.ReadLine().ToUpper();
            newVehicle.Used = newVehicleUsed == "YES" || newVehicleUsed == "Y" ? newVehicle.Used = false : newVehicle.Used = true;
            

           
            if (newVehicle is Car)
            {
                var newCar = (Car)newVehicle;
                newCar.StockCode = newCar.GenerateStockCode();
                Cars.Add(newCar);
            }

            else
            {
                var newMotorcycle = (MotorCycle)newVehicle;
                newMotorcycle.StockCode = newMotorcycle.GenerateStockCode();
                MotorCycles.Add(newMotorcycle); }

            Console.WriteLine("Succefully Added!");
            Console.ReadKey(true);   
        }
        

    }
}
