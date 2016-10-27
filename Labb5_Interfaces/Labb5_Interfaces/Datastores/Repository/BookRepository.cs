using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class BookRepository : IRepository //Communicates with the list of books

    {
        public void AddItem(Item newItem)
        {
            ItemLists.Books.Add((Book)newItem);
        }

        public Item[] GetItems()
        {
            return ItemLists.Books.ToArray();
        }

        public void RemoveItem(Item newItem)
        {
            ItemLists.Books.Remove((Book)newItem);
        }
    }
}
