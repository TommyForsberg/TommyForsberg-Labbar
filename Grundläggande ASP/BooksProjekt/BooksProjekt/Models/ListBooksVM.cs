using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksProjekt.Models
{
    public class ListBooksVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAClassic { get; set; }
    }
}
