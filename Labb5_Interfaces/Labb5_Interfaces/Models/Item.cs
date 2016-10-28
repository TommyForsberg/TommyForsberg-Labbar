using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb5_Interfaces
{
    public abstract class Item
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public virtual string Properties()
        {
            return String.Format("{0,-30}{1,-10}", Title, Year);
        }

    }
}