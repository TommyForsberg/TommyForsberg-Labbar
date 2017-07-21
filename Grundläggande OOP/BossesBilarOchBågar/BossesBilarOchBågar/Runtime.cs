using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class Runtime //All menus and choices, all Switch-menus and LINQ-filtering.
    {
        VehicleHandler vehicleHandler = new VehicleHandler();
        public bool IsProgramRunning { get; set; }
        public void Start()
        {
             IsProgramRunning = true;
            do
            {
                Menu.PrintMainMenu();
                StartMenu();
            } while (IsProgramRunning);
        }

        public void StartMenu()
        {
            var selectedVehicle = new List<Vehicle>(); //New list is created wich is to be handled and filtered
            int input = ValidInput.ValidInteger();
            Menu.PrintTabSorting();
            switch (input)
            {
                case 1:
                    selectedVehicle.AddRange(VehicleHandler.Cars); //Adds all cars to the created list
                    FilteringOptions(selectedVehicle); 
                    break;
                case 2:
                    selectedVehicle.AddRange(VehicleHandler.MotorCycles); //Adds all motorycles to the created list
                    FilteringOptions(selectedVehicle);
                    break;
                case 3: BuyMenu();
                    break;
                case 4: IsProgramRunning = false;
                    break;
            }
        }

        public static void FilteringOptions(List<Vehicle> selectedVehicle) //Filtering with LINQ
        {
            bool filtering = true; //The filtering will be done several times as this is true
            var vehicleHandler = new VehicleHandler();
            do {
                Console.Clear();
                Menu.PrintTabSorting();
                if (selectedVehicle.Count == 0) //This is shown if LINQ-filtering gives no results
                { Console.WriteLine("No Results"); }
                else
                { vehicleHandler.VehicleListing(selectedVehicle); }
                Menu.PrintFilterChoice();

                int input = ValidInput.ValidInteger();
                switch (input)
                {
                    case 1:   //LINQ-filter for brand input by user
                        Console.WriteLine("Input Brand:");
                        string brand = Console.ReadLine();
                        selectedVehicle = selectedVehicle
                            .Where(Vehicle => Vehicle.Brand.ToUpper() == brand.ToUpper())
                            .ToList();
                        break;

                    case 2: //LINQ-filter for color input by user
                        Console.WriteLine("Input Color:");
                        string color = Console.ReadLine();
                        selectedVehicle = selectedVehicle
                        .Where(Vehicle => Vehicle.Color.ToUpper() == color.ToUpper())
                        .ToList();
                        break;

                    case 3: //LINQ-filter for Used or New input by user
                        selectedVehicle = selectedVehicle.Where(Vehicle => Vehicle.Used == true).ToList<Vehicle>();
                        break;
                    case 4: //LINQ-filter for year input by user
                        Console.WriteLine("Input Year:");
                        int year = ValidInput.ValidInteger();
                        selectedVehicle = selectedVehicle
                        .Where(Vehicle => Vehicle.Year == year)
                        .ToList();
                        break;

                    case 5:  //Initiate delete process
                        Console.WriteLine("Confirm with Stock CODE:");
                        string inputStock = Console.ReadLine();
                        vehicleHandler.ScrapOrSellVehicle(inputStock, selectedVehicle);
                        break;

                    case 6: filtering = false;
                        break;
            }
            } while (filtering == true);
        }
        public static void BuyMenu() //Menu for adding vehicle to list
        {
            bool buyMenu = true;
            do 
            {
                Console.Clear();
                Console.WriteLine("What type of Vehicle do you want to add?");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Motorcycle");
                Console.WriteLine("3. Return");
                int secondInput = ValidInput.ValidInteger();
                var vehicleHandler = new VehicleHandler();
                switch (secondInput)
                {
                    case 1:
                        var newCar = new Car();
                        vehicleHandler.AddToStock(newCar);
                        break;
                    case 2:
                        var newMotorcycle = new MotorCycle();
                        vehicleHandler.AddToStock(newMotorcycle);
                        break;
                    case 3:buyMenu = false;
                        break;
                }
                buyMenu = false;
            } while (buyMenu);
        }
    }
}
