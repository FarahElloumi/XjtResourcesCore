using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace XJTResourcesCore.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Category : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public int CategoryId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Sub Category")]
        [MaxLength(256)]
        public string SubCategory { get; set; }

        
        public string NameSubCategory { get { return (SubCategory != null) ? Name + " / " + SubCategory : Name ; } }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Description")]
        [UIHint("TextArea")]
        public string Description { get; set; }
    }
}