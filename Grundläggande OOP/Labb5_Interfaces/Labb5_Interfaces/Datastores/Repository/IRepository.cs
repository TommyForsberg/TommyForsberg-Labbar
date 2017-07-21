using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb5_Interfaces
{
    interface IRepository
    {
        Item[] GetItems();
        void AddItem(Item newItem);
        void RemoveItem(Item newItem);

        
    }
}