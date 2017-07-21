using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Film : Event
    {
        public string FilmTitle { get; set; }
        public string Director { get; set; }
    }
}