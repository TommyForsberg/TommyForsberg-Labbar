using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_StoreApp
{
    class UI
    {
        public static void PrintBorder()
        {
            Console.WriteLine("  {0,-6}{1,-15}{2,-15}{3}", "Meat", "Type", "Price/Qty", "Qty in Stock");
            Console.Write(Environment.NewLine);
        }
        public static int PrintMeatMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Shop Beef");
            Console.WriteLine("2. Shop Pork");
            Console.WriteLine("3. Shop Fish");
            Console.WriteLine("4. Checkout");
            Console.WriteLine("5. Administrate store");
            Console.WriteLine("6. Exit");
           return int.Parse(Console.ReadLine());
        }
        public static void PrintAddToCart()
        {
            Console.WriteLine("1. Add to cart");
            Console.WriteLine("2. Return");
        }

        public static int ChooseProduct()
        {
            Console.WriteLine("What product? (Choose corresponding No):");
            return int.Parse(Console.ReadLine());
        }

        public static int ChooseQuantity()
        {
            Console.WriteLine("How much do you want to buy?");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintList(Product[] choosenList)
        {
            Console.Clear();
            PrintBorder();
            int index = 1;
            foreach (var product in choosenList)
            {
                Console.WriteLine(index + " {0,-6}{1,-15}{2,-15}{3}", product.GetType().Name, product.ProductType, product.Price + " Sek/Hekto", product.Quantity );
                index++;
            }
            Console.WriteLine(Environment.NewLine);
        }
        public static void PrintAdmin()
        {
            Console.Clear();
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Return");
        }
        public static int ChooseType(string label)
        {
            Console.Clear();
            Console.WriteLine("What type of meat do you want to " +label +"?");
            Console.WriteLine("1. Beef");
            Console.WriteLine("2. Pork");
            Console.WriteLine("3. Fish");
            Console.WriteLine("4. Return");
            return int.Parse(Console.ReadLine());
        }
         public static Product InputMeatSpecifications(Product newMeat)
        {
            Console.WriteLine("What part of meat/type of fish?");
            newMeat.ProductType = Console.ReadLine();
            Console.WriteLine("What price?");
            newMeat.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("How much in stock?");
            newMeat.Quantity = int.Parse(Console.ReadLine());
            return newMeat;
        }

    }
}
