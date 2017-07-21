using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb7_StoreApp
{
    public abstract class Product : ISellable
    {
        public int Price { get; set; }

        public string ProductType
        {
            get; set;
        }
        public int Quantity { get; set; }
    }
}