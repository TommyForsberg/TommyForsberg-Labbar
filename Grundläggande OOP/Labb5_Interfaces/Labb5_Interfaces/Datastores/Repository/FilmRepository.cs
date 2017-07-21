using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb5_Interfaces
{
    public class FilmRepository : IRepository //Communicates with the list of films
    {
        public Item[] GetItems()
        {
            return ItemLists.Films.ToArray();
        }

        public void AddItem(Item newItem)
        {
            ItemLists.Films.Add((Film)newItem);
        }

        public void RemoveItem(Item newItem)
        {
            ItemLists.Films.Remove((Film)newItem);
        }
    }
}