using System;
using System.Collections.Generic;
using System.Linq;

namespace XJTResourcesCore.Models
{
    /// <summary>
    /// Link
    /// </summary>
    public class Link : BaseClass
    {
        /// <summary>
        /// primary key.
        /// </summary>
        public int LinkId { get; set; }

        /// <summary>
        /// name of webpage
        /// </summary>
        public string UrlTitle { get; set; }

        /// <summary>
        /// stored as a string to be used by application for populating a link 
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Defines what type of link is contained...  mailto: https: http: etc...
        /// </summary>
        public string LinkType { get; set; } 


    }
}