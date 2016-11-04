using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_StoreApp
{
    class ListManager
    {
        public List<Product> BeefMeat { get; set; }
        public List<Product> PorkMeat { get; set; }
        public List<Product> Fishes { get; set; }
        public List<Product> CurrentList { get; set; }
         public ListManager()
        {
            BeefMeat = new List<Product> {
                new Beef {Price = 50, ProductType = "Chuck", Quantity = 100 },
                new Beef {Price = 60, ProductType = "Rib", Quantity = 200 },
                new Beef {Price = 80, ProductType ="Tenderloin", Quantity = 50},
                new Beef {Price = 50, ProductType ="Round", Quantity = 60 }
            };

            PorkMeat = new List<Product>
            {
                new Pork {Price = 40, ProductType = "Ham", Quantity = 200 },
                new Pork {Price = 45, ProductType = "Head", Quantity = 90 },
                new Pork {Price = 50, ProductType = "Loin", Quantity = 100 }
            };

            Fishes = new List<Product>
            {
                new Fish {Price = 40, ProductType = "Red Snapper", Quantity = 30 },
                new Fish {Price = 50, ProductType = "Pollock", Quantity = 50 },
                new Fish {Price = 40, ProductType = "Mullet", Quantity = 15 },
                new Fish {Price = 60, ProductType = "Catfish", Quantity = 10 },
                new Fish {Price = 25, ProductType = "Harring", Quantity = 25 },
            };
        }

        public Product[] FetchList(int index)
        {
            CurrentList = new List<Product>();
            switch (index)
            {
                case 1: CurrentList.AddRange(BeefMeat);
                    return BeefMeat.ToArray();
                case 2:
                    CurrentList.AddRange(PorkMeat);
                    return PorkMeat.ToArray();
                case 3:
                    CurrentList.AddRange(Fishes);
                    return Fishes.ToArray();
                default: return null;
            }
        }
        public bool ManageOrder(int suggestedQty, int productIndex, Product product)
        {
            if (suggestedQty < CurrentList[productIndex].Quantity)
            {
                if (product is Beef)
                    BeefMeat[productIndex].Quantity -= suggestedQty;
                if (product is Pork)
                    PorkMeat[productIndex].Quantity -= suggestedQty;
                if (product is Fish)
                    Fishes[productIndex].Quantity -=suggestedQty;
                return true;
            }
            else
            { return false; }
        }
    }
}
