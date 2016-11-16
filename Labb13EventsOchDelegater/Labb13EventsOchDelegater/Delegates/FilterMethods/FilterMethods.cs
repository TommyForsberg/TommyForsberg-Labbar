using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class FilterMethods
    {
        public static bool FilterMinutes(Film film)
        {
            return film.Genre.Equals(Film.GenreType.Drama);
        }
    }
}
