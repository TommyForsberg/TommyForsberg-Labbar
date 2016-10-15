using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2
{
    public class Toad : Amphibia
    {
        public int walkingLength { get; set; }
        public bool Metamorphosis { get; set; }

        public override string Move()
        {
            return String.Format("walks the walk. But doesn't talk the talk.", base.Move());
        }
    }
}