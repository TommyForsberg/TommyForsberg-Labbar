using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CockiesLabb.Models
{
    public class UserDisplayVM
    {
        [Required]
        public string UserName { get; set; }
        public bool AcceptCookies { get; set; }
    }
}
