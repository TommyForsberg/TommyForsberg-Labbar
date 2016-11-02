using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb7_StoreApp
{
    public interface ISellable
    {
        int Price { get; set; }
        string ProductType { get; set; }

    }
}