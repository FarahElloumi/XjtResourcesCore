using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XJTResourcesCore.Models
{
    public class Announcement : BaseClass
    {
                
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CssStyles { get; set; }

        
    }
}
