using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace XJTResourcesCore.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public override string UserName
        {
            get
            {
                return base.UserName;
            }

            set
            {
                base.UserName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DOH { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Base { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Is Pilot?")]
        public bool IsPilot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Push Notifications")]
        public bool PushNotifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }
    }
}
