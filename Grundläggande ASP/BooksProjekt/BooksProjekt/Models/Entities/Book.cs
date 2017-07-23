using System;
using System.Collections.Generic;

namespace BooksProjekt.Models.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
