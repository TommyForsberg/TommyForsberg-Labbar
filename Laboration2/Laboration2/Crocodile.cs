using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2
{
    public class Crocodile : Reptile
    {
        public bool HasEatenHuman { get; set; }
        public int DaysOfStarving { get; set; }

        public override string Move()
        {
            return String.Format("swims under water. \nIf days are hot, it lures in the shadows. \nAlways waiting for its prey.",base.Move());
        }
    }
}