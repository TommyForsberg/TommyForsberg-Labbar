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
            do
            {
                Menu.PrintMainMenu();
                StartMenu();
            } while (true);
        }

        public void StartMenu()
        {
            var selectedVehicle = new List<Vehicle>();
            int input = ValidInput.ValidInteger();
            Menu.PrintTabSorting();
            switch (input)
            {
                case 1:
                    selectedVehicle.AddRange(VehicleHandler.Cars);
                    FilteringOptions(selectedVehicle);
                    break;
                case 2:
                    selectedVehicle.AddRange(VehicleHandler.MotorCycles);
                    FilteringOptions(selectedVehicle);
                    break;
                case 3: BuyAndSellMenu();
                    break;
             
            }
        }

        public static void FilteringOptions(List<Vehicle> selectedVehicle)
        {
            bool filtering = true;
            var vehicleHandler = new VehicleHandler();
            do {
                Console.Clear();
                Menu.PrintTabSorting();
                if (selectedVehicle.Count == 0)
                { Console.WriteLine("No Results"); }
                else
                { vehicleHandler.VehicleListing(selectedVehicle); }
                Menu.PrintFilterChoice();

                int input = ValidInput.ValidInteger();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Input Brand:");
                        string brand = Console.ReadLine();
                        selectedVehicle = selectedVehicle
                            .Where(Vehicle => Vehicle.Brand.ToUpper() == brand.ToUpper())
                            .ToList();
                        break;

                    case 2:
                        Console.WriteLine("Input Color:");
                        string color = Console.ReadLine();
                        selectedVehicle = selectedVehicle
                        .Where(Vehicle => Vehicle.Color.ToUpper() == color.ToUpper())
                        .ToList();
                        break;

                    case 3:
                        selectedVehicle = selectedVehicle.Where(Vehicle => Vehicle.Used == true).ToList<Vehicle>();
                        break;
                    case 4:
                        Console.WriteLine("Input Year:");
                        int year = ValidInput.ValidInteger();
                        selectedVehicle = selectedVehicle
                        .Where(Vehicle => Vehicle.Year == year)
                        .ToList();
                        break;

                    case 5:
                        Console.WriteLine("Confirm with Stock CODE:");
                        string inputStock = Console.ReadLine();
                        vehicleHandler.ScrapOrSellVehicle(inputStock, selectedVehicle);
                        break;

                    case 6: filtering = false;
                        break;
            }
            } while (filtering == true);
        }
        public static void BuyAndSellMenu()
        {
            Menu.PrintBuyAndAdd();
            int input = ValidInput.ValidInteger();
            switch(input)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        //public static void 


    }
}
