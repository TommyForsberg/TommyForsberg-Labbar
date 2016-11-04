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
        Customer customer = new Customer();

        public void AddToCart()
        {
            int choosenIndex = UI.ChooseProduct();
            Product choosenProduct = listManager.CurrentList[choosenIndex-1];
            int choosenQuantity = UI.ChooseQuantity();
           
            bool isAccepted = listManager.ManageOrder(choosenQuantity, choosenIndex-1, choosenProduct);
            if (isAccepted)
            {
                customer.AddToMyCart(choosenQuantity, choosenProduct);
            }
            else
            {
                Console.WriteLine("Out of stock");
                Console.ReadKey(true);
            }
        }

        public void DisplayProducts(int input)
        {
            UI.PrintList(listManager.FetchList(input));
        }

        public void CheckOut()
        {
            UI.PrintList(customer.ShoppingCart.ToArray());
            customer.Checkout();
        }

        public void AddToStore()
        {
            Product newmeat;
            int choosenMeat = UI.ChooseType("add");
            switch(choosenMeat)
            {
                case 1: newmeat = new Beef() ;
                    UI.InputMeatSpecifications(newmeat);
                    listManager.BeefMeat.Add(newmeat);
                        break;
                case 2:
                    newmeat = new Pork();
                    UI.InputMeatSpecifications(newmeat);
                    listManager.PorkMeat.Add(newmeat);
                    break;
                case 3:
                    newmeat = new Fish();
                    UI.InputMeatSpecifications(newmeat);
                    listManager.Fishes.Add(newmeat);
                    break;
                case 4:
                    break;
            }
        }
        public void RemoveFromStore()
        {
            int choiceOfMeat = UI.ChooseType("remove");
            if (choiceOfMeat <= 3)
            {
                DisplayProducts(choiceOfMeat);
                int choiceOfProduct = UI.ChooseProduct()-1;
                if (choiceOfMeat == 1)
                    listManager.BeefMeat.RemoveAt(choiceOfProduct);
                else if (choiceOfMeat == 2)
                    listManager.PorkMeat.RemoveAt(choiceOfProduct);
                else
                    listManager.Fishes.RemoveAt(choiceOfProduct);
            }
        }
    }
}
