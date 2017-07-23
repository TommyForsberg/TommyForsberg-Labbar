using System;
using System.Collections.Generic;

namespace CatHome.Models.Entities
{
    public partial class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Anger { get; set; }
        public double Weight { get; set; }
    }
}
