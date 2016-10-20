using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljettbokning
{
    class Runtime
    {
        public static string CurrentUser { get; set; }
        EventHandler eventHandler = new EventHandler();
        public bool IsProgramRunning { get; set; }

        public void Start()
        {
            Console.WriteLine("Event Booker 1.0");
            LoggOn();
            IsProgramRunning = true;
            do
            {
                MainMenu();
            } while (IsProgramRunning);
        }

        void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hi " + CurrentUser + " You are now logged in!\n");
            Console.WriteLine("1. Show/Book Events");
            Console.WriteLine("2. Show my bookings");
            Console.WriteLine("3. Change current user");
            Console.WriteLine("4. Exit");
            int input;
            int.TryParse(Console.ReadLine(), out input);
         
            switch(input)
            {
                case 1:
                    Console.Clear();
                    eventHandler.ListOrBook();
                    break;
                case 2: eventHandler.MyBookings();
                    break;
                case 3: LoggOn();
                    break;
                case 4:IsProgramRunning = false;
                    break;
                default:
                    Console.WriteLine("You have inserted {0}", input);
                    Console.ReadKey();
                    break;
            }
        }
        public void LoggOn()
        {
            Person newPerson = new Person();
            Console.WriteLine("First name:");
            newPerson.FirstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            newPerson.LastName = Console.ReadLine();
            CurrentUser = newPerson.ToString();

            Person singlePerson = eventHandler.Bookings.SingleOrDefault(person => String.Equals(person.ToString(), Runtime.CurrentUser));
            if (singlePerson != null) { Console.WriteLine("Welcome Back"); Console.ReadLine(); }
         
            else
            {
                newPerson.MyEvents = new List<Event>();
                eventHandler.Bookings.Add(newPerson);
                Console.WriteLine("Welcome!");
                Console.ReadLine();
            }
        }
    }
}
