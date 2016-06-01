using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace XJTResourcesCore.Models
{
    public class Version : BaseClass
    {
        public int VersionId { get; set; }


        public double AndroidNum
        {
            get;
            set;
        }

        public DateTime AndroidDate
        {
            get;
            set;
        }


        public double iOSNum
        {
            get;
            set;
        }

        public DateTime iOSDate
        {
            get;
            set;
        }


        public double WinUWPNum
        {
            get;
            set;
        }

        public DateTime WinUWPDate
        {
            get;
            set;
        }
    }


    /// <summary>
    /// Consider this design....
    /// this won't actually be pushed to DB since we didn't tell the Context it exists...
    /// just a thought..
    /// </summary>
    public class VersionBeta : BaseClass
    {
        //technically there will only ever be 3 apps listed, if you want a history then
        //we would need to go back and setup a version history system...        
        public int VersionId { get; set; }

        /// <summary>
        /// Droid, iOS, Windows
        /// </summary>
        [MaxLength(8)]
        public string OperatingSystem { get; set; }
        
        /// <summary>
        /// Details about what was changed...
        /// </summary>
        public string Changes { get; set; }

        /// <summary>
        /// Current deployed version number of client application
        /// </summary>
        public string VersionNum { get; set; }
    }
}