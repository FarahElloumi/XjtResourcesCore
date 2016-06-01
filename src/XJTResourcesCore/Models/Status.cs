using System;
using System.Collections.Generic;
using System.Linq;

namespace XJTResourcesCore.Models
{
    public class Status : BaseClass
    {
        public int StatusId { get; set; }

        public string Name { get; set; }

        public int StatusTypeId { get; set; }
        
        public virtual StatusType StatusType { get; set; }


    }
}