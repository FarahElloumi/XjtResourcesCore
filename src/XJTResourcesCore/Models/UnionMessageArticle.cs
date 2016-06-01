using System;
using System.Collections.Generic;
using System.Linq;

namespace XJTResourcesCore.Models
{
    public class UnionMessageArticle : BaseClass
    {

        public UnionMessageArticle()
        {

        }
        public int UnionMessageArticleId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool IsHtml { get; set; }
        
    }
}