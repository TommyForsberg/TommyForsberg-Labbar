﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb14_klasser
{
    public abstract class Publication
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}