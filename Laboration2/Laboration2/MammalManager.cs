using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class MammalManager
    {
        public List<Monkey> Monkeys { get; set; }
        public List<Cat> Cats { get; set; }

        public MammalManager()
        {
            Monkeys = new List<Monkey>()
            {
                new Monkey  { Age = 10, Weight =72 }
            };

            Cats = new List<Cat>()
            {
                new Cat {Age = 4, Owner ="Katrin Johansson", Habitat ="Domesticated", Weight = 3, ColorOfFur = "Grey Spreckled", Diet = "Tuna"},
                new Cat {Age = 8, Owner ="Björn Svensson", Habitat ="Domesticated", Weight = 4, ColorOfFur = "Grey & Orange Spreckled", Diet = "Tuna"}
            };
        }
    }
}
