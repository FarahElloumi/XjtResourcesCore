using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace XJTResourcesCore.Models
{
    [JsonObject(IsReference=true)]
    public class Comment : BaseClass
    {

        
        public Comment()
        {

        }

        public int CommentId { get; set; }

        public int HotelId
        {
            get;
            set;
        }

        public string EntertainmentComment
        {
            get;
            set;
        }

        public string FoodComment
        {
            get;
            set;
        }

        public string HotelComment
        {
            get;
            set;
            
        }

        public int Rating
        {
            get;
            set;
        }

        public virtual Hotel Hotel
        {
            get;
            set;
        }


    }
}