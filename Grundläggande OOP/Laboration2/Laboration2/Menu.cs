using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Menu
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Remove Animal");
            Console.WriteLine("3. List Animals" );
            Console.WriteLine("4. EXIT");
        }

        public static void AnimalMenu(string lable)
        {
            Console.Clear();
            Console.WriteLine(lable);
            Console.WriteLine("1. Amphibia");
            Console.WriteLine("2. Mammal");
            Console.WriteLine("3. Reptile");
            Console.WriteLine("4. Return");
        }

        public static void AmphibiaMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Frog");
            Console.WriteLine("2. Toad");
        }
        public static void MammalMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Cat");
        }
        public static void ReptileMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Crocodile");
            Console.WriteLine("2. Snake");
        }
        public static void ListAnimalsMenu()
        {
            Console.Clear();
            Console.WriteLine("1. All animals");
            Console.WriteLine("2. Frogs");
            Console.WriteLine("3. Toads");
            Console.WriteLine("4. Monkeys");
            Console.WriteLine("5. Cats");
            Console.WriteLine("6. Crocodiles");
            Console.WriteLine("7. Snakes");
        }
    }
}
