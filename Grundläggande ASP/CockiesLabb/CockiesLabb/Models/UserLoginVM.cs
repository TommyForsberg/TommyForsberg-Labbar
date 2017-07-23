using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CockiesLabb.Models
{
    public class UserLoginVM
    {
        [Required]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name="Accept Cookies")]
        public bool AcceptCookies { get; set; }
    }
}
