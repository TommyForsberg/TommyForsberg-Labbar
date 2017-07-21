using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_StoreApp
{
    class Customer
    {
        int Total { get; set; }
        public List<Product> ShoppingCart { get; set; }
        public Customer()
        {
            ShoppingCart = new List<Product>();
        }

        public void Checkout() //förslagsvis beräkna checkout här
        {
            int[] cart = new int[ShoppingCart.Count];
            int index = 0;
            foreach (var product in ShoppingCart)
            {
                cart[index] = product.Price * product.Quantity;
                index++;
            }
            int total = 0;
            for (int i = 0; i < cart.Length; i++)
            {
                total +=cart[i];
            }
            Console.WriteLine("Total: " + total);
            Console.ReadLine();
        }

        public void AddToMyCart(int quantity, Product choosenProduct)
        {
            Product singleProduct = ShoppingCart.SingleOrDefault(product => String.Equals(product.ProductType, choosenProduct.ProductType));
            if (singleProduct != null)
                singleProduct.Quantity += quantity;

            else
            {
                if (choosenProduct is Beef)
                {
                    Beef newPurchase = new Beef()
                    {
                        ProductType = choosenProduct.ProductType,
                        Quantity = quantity,
                        Price = choosenProduct.Price
                    };
                    ShoppingCart.Add(newPurchase);
                }

                else if (choosenProduct is Pork)
                {
                    Pork newPurchase = new Pork()
                    {
                        ProductType = choosenProduct.ProductType,
                        Quantity = quantity,
                        Price = choosenProduct.Price
                    };
                    ShoppingCart.Add(newPurchase);
                }

                else if (choosenProduct is Fish)
                {
                    Fish newPurchase = new Fish()
                    {
                        ProductType = choosenProduct.ProductType,
                        Quantity = quantity,
                        Price = choosenProduct.Price
                    };
                    ShoppingCart.Add(newPurchase);
                }
            }
        }
    }
    }
