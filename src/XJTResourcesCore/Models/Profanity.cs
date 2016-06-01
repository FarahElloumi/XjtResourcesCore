using System;
using System.Collections.Generic;
using System.Linq;

namespace XJTResourcesCore.Models
{
    public class Profanity : BaseClass
    {
        public int ProfanityId {get;set;}
        public string Word { get; set; }

        //possible to assign severity ranking in future... for email conversation.. :P, pro-stands?

    }
}