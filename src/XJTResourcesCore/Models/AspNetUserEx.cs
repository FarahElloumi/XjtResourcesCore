using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace XJTResourcesCore.Models
{

    public class AspNetUserEx 
    {      
        [Key]
        public string UserId { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public string SecurityAnswerSalt { get; set; }
    }
}