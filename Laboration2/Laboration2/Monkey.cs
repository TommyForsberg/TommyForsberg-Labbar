using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2
{
    public class Monkey : Mammal
    {
        public int HoursOfSleep { get; set; }
        public string ColorOfEyes { get; set; }

        public override string Move()
        {
            return String.Format("{0}often climbs in trees, or runs on the ground.", base.Move());
        }

        public override string Introduction()
        {
            return String.Format("The Monkey {0}", base.Introduction());
        }
    }

    
}