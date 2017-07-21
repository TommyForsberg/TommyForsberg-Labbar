using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb5_Interfaces
{
    public class Book : Item
    {

        public string Author { get; set; }
        public override string Properties()
        {
            return string.Format("{0,-20}{1,-25}", Author, base.Properties());
        }
    }
}