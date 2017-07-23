using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatHome.Models
{
    public class CreateCatVM
    {
        [Required]
        [Display(Prompt = "Name")]
        public string Name { get; set; }
        [Required]
        [Range(0,10)]
        public int Anger { get; set; }
        [Required]
        public double Weight { get; set; }
    }
}
