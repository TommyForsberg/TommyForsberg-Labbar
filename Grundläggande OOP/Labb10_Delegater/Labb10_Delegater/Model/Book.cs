using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10_Delegater
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public enum GenreType { Thriller, Drama, Comedy, Adventure, Classic}
        public GenreType Genre { get; set; }
    }
}
