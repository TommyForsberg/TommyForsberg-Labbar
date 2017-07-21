using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2
{
    public class Snake : Reptile
    {
        public bool IsVenomous { get; set; }
        public string Sound { get; set; }

        public override string Move()
        {
            return String.Format("{0}crawls or curves itself, if attacking it shake its tail aggressively.",  base.Move());
        }
    }
}