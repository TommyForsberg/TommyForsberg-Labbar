using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_StoreApp
{
    class ButcherShop
    {
        ShopController shopController = new ShopController();
        public void Start()
        {
            bool loop = true;
            do
            {
                int input = UI.PrintMeatMenu();
                if (input <= 3)
                {
                    shopController.DisplayProducts(input);
                    Shop(input);
                }
                else if (input == 4)
                    shopController.CheckOut();
                else if (input == 5)
                    AdministrateStore();
                else
                    loop = false;
            } while (loop);
        }

        void Shop(int input2)
        {
            bool loop = true;
            
            do
            {
                shopController.DisplayProducts(input2);
                UI.PrintAddToCart();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        shopController.AddToCart();
                        break;
                    case 2: loop = false;
                        break;
                    default: break;
                }
            } while (loop);
        }
        public void AdministrateStore()
        {
            bool run = true;
            do
            {
                UI.PrintAdmin();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        shopController.AddToStore();
                        break;
                    case 2:
                        shopController.RemoveFromStore();
                        break;
                    case 3: run = false;
                        break;
                }
            } while (run);

        }
    }
}
