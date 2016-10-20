using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class Runtime
    {
        VehicleHandler vehicleHandler = new VehicleHandler();

        public void Start()
        {
            var selectedVehicle = new List<Vehicle>();


            Menu.PrintMainMenu();
            int input = ValidInput.ValidInteger();

            switch(input)
            {
                case 1:
                    selectedVehicle.AddRange(vehicleHandler.Cars);
                    Menu.PrintTabSorting();
                    vehicleHandler.VehicleManager(selectedVehicle);
                    FilteringOptions();
                    break;
                case 2:

                    //vehicleHandler.VehicleFiltering();
                    break;
                default:
                    Console.WriteLine("something");
                    Console.ReadKey();
                    break;
            }
        }

        public static void FilteringOptions()
        {
            var vehicleHandler = new VehicleHandler();
            int input = ValidInput.ValidInteger();
            switch(input)
            {
                case 1:

                    break;

                case 2:
                    Console.WriteLine("Write Color");
                    string color = Console.ReadLine();
                    vehicleHandler.VehicleFiltering(color);
                    

                    break;
                
            }
        }


        
    }
}
