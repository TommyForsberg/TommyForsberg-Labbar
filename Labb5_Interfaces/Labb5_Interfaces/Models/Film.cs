using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb5_Interfaces
{
    public class Film : Item
    {
        public enum GenreType
        {
            Action = 1,
            Thriler,
            Comedy,
            Drama,
            Horror
        }
        public string Director { get; set; }
        public GenreType Genre { get; set; }
    }
}