using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksProjekt.Models
{
    public class CreateBookVM
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
