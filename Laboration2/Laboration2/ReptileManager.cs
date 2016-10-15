using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class ReptileManager
    {
        public List<Crocodile> Crocodiles { get; set; }
        public List<Snake> Snakes { get; set; }

        public ReptileManager()
        {
            Crocodiles = new List<Crocodile>()
            {
                new Crocodile {Age = 45, CanRun = true, DaysOfStarving = 21, ColorOfScale = "Dark Green", Weight = 110},
                new Crocodile {Age = 14, CanRun = true, DaysOfStarving = 2, ColorOfScale = "Dark Green", Weight = 115}
            };

            Snakes = new List<Snake>()
            {
                new Snake { NumberOfTeeth = 6, Weight = 3.2, Habitat = "Desert & Forest", Sound = "Rattle", Age = 3 }
            };
        }
    }
}
