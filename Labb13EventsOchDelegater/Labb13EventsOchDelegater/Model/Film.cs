using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class Film
    {
        public int Length { get; set; }
        public string Title { get; set; }
        public enum GenreType { Drama = 1, Komedi, Action }
        public GenreType Genre { get; set; }
    }
}
