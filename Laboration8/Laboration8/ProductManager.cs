using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration8
{
    class ProductManager
    {
        public List<IProduct> Items { get; set; }

        public ProductManager()
        {
            Items = new List<IProduct>()
            {
                new Item {Id = 001, Name = "Samsung", Price = 1200 },
                new Item {Id = 002, Name = "Iphone", Price = 1300 },
                new Item {Id = 230, Name = "Galaxy", Price = 1500 },
                new Item {Id = 011, Name = "Nokia", Price = 1700 }
        };
        }

        public string FormatProductNames(string[] someString)
        {
            string result = null;
            int index = 0;

            foreach (var mString in someString)
            {
                index++;
                if (index < someString.Length)
                {
                    result += mString + ", ";
                }
                else
                    result += mString;
            }
            return result;
        }
        public double PriceCalculation(double[] someDoubles )
        {
            double result = 0;
            double result2 = 0;
            foreach (var price in someDoubles)
            {
                if (price < 1000)
                    result += price;
                else
                    result2 += price;
            }
            
            return (result * 1.20)+(result2*0.9);
        }
    }
}
