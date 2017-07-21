using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb14_klasser
{
    public class Book : Publication
    {
        public enum GenreType { Classic, SciFi, Crime}
        public GenreType Genre { get; set; }
        public int Pages { get; set; }
    }
}