using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16InterfaceRepository
{
    class UI
    {

        public static ConsoleKey MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Ändra Produkt i lista");
            Console.WriteLine("2. Radera Produkt i lista");
            Console.WriteLine("3. Lägg till Produkt i lista");
            Console.WriteLine("4. Ändra produkt i fil(JSON)");
            Console.WriteLine("5. Radera produkt i fil(JSON)");
            Console.WriteLine("6. Lägg till produkt i fil(JSON)");
            return Console.ReadKey(true).Key;
        }
        
        public static Product CreateProduct(int id)
        {
            Console.WriteLine("Vad för produkt vill du lägga till?");
            return new Product { Type = Console.ReadLine(), Id = id };
        }

        public static int SelectProduct()
        {
            Console.WriteLine("Välj produkt:");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintProducts(Product[] products)
        {
            int index = 1;
            foreach (var product in products)
            {

                Console.WriteLine(index + " " + product.Type);
                index++;
            }
        }

        public static Product ChangeProduct(Product temp)
        {
            Console.WriteLine("Ange ny produkttyp");
            temp.Type = Console.ReadLine();
            return temp;
        }
    }
}
