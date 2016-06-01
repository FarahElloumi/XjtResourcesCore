using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;


namespace XJTResourcesCore.Models
{
    public abstract class BaseClass
    {
        public BaseClass()
        {

            Inserted = DateTime.UtcNow;

            Modified = (DateTime)SqlDateTime.MinValue;
        }

        [UIHint(uiHint:"BooleanButtonLabel")]        
        public bool IsActive { get; set; } = true;

        [Display(Name = "Created")]
        //date it was created
        public virtual DateTime Inserted { get; set; }

        //date it was last modified
        [DataType(DataType.DateTime)]        
        public virtual DateTime Modified { get; set; }

        //who last modified the entry
        [Display(Name ="Modified By")]
        public virtual string ModifiedBy { get; set; } = string.Empty;

        //who was original entrant
        [Display(Name = "Created By")]
        public virtual string PostedBy { get; set; } 

    }
}