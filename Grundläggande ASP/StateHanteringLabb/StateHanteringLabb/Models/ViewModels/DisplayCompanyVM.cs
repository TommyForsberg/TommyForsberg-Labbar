using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StateHanteringLabb.Models.ViewModels
{
    public class DisplayCompanyVM
    {
        public string Greetings { get; set; }
        [Display(Name="Company name: ")]
        public string Name { get; set; }
        [Display(Name="Support E-Mail: ")]
        public string Email { get; set; }
    }
}
