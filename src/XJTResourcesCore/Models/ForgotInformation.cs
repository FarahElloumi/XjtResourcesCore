using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace XJTResourcesCore.Models
{

    public class ForgotInformation
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Email")]        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
