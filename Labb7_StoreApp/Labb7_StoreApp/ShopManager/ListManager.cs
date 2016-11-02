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

         public ListManager()
        {
            BeefMeat = new List<Product> {
                new Beef {Price = 50, ProductType = "Chuck" },
                new Beef {Price = 60, ProductType = "Rib" },
                new Beef {Price = 80, ProductType ="Tenderloin" },
                new Beef {Price = 50, ProductType ="Round" }

            };

            PorkMeat = new List<Product>
            {
                new Pork {Price = 40, ProductType = "Ham" },
                new Pork {Price = 45, ProductType = "Head" },
                new Pork {Price = 50, ProductType = "Loin" }
            };

            Fishes = new List<Product>
            {
                new Fish {Price = 40, ProductType = "Red Snapper" },
                new Fish {Price = 50, ProductType = "Pollock" },
                new Fish {Price = 40, ProductType = "Mullet" },
                new Fish {Price = 60, ProductType = "Catfish" },
                new Fish {Price = 25, ProductType = "Harring" },
            };
        }


    }
}
