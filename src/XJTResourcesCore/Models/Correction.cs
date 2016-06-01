using System;
using System.Collections.Generic;
using System.Linq;

namespace XJTResourcesCore.Models
{
    public class Correction : BaseClass
    {
        public int CorrectionId { get; set; }
        public string UserId { get; set; }        
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public bool IsUpdated { get; set; }
        public string Changes { get; set; }
        public string CorrectiveAction { get; set; }
    }
}