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
            UI.PrintMeatMenu();
            int input = int.Parse(Console.ReadLine());
           shopController.PrintList(shopController.FetchList(input));
        }
    }
}
