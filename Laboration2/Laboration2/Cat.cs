using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2
{
    public class Cat : Mammal
    {
        public string Owner { get; set; }
        public string Name { get; set; }

        public override string Move()
        {
            return String.Format("sneaks by when interrested. Otherwise the cat can stroll or rest.", base.Move());
        }
    }
}