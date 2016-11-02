using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_StoreApp
{
    class ShopController
    {
        ListManager listManager = new ListManager();

        public Product[] FetchList(int index)
        {
            switch(index)
            {
                case 1: return listManager.BeefMeat.ToArray();
                case 2: return listManager.PorkMeat.ToArray();
                case 3: return listManager.Fishes.ToArray();
                default: return null;
            }
        }

        public void PrintList(Product[] choosenList)
        {
            foreach(var product in choosenList)
            {
                Console.WriteLine("{0,-6}{1,-15}{2}Sek/Hekto",product.GetType().Name, product.ProductType, product.Price);
            }
        }
    }
}
