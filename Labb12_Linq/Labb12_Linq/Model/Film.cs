using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12_Linq
{
    class Film
    {
        public int Length { get; set; }
        public string Title { get; set; }
        public enum GenreType { Drama = 1, Komedi, Action }
        public GenreType Genre { get; set; }

        public string PrintFormat()
        {
            return String.Format("{0,-25}{1,10}{2,10}min",Title, Genre, Length);
        }

    }

 
}
