using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2
{
    public class Frog : Amphibia
    {
        public int JumpLength { get; set; }
        public string Pattern { get; set; }

        public override string Move()
        {
            return String.Format("{0} jumps or swims. This particular frog jumps {1} centimetres.", base.Move(), JumpLength);
        }
    }
}