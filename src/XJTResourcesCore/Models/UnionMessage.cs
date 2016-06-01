using System;
using System.Collections.Generic;
using System.Linq;

namespace XJTResourcesCore.Models
{
    public class UnionMessage : BaseClass
    {
       public int UnionMessageId { get; set; }

        public string Name { get; set; }
        
        public int UnionMessageArticleId { get; set; }

        public virtual UnionMessageArticle UnionMessageArticle { get; set; }
    }
}