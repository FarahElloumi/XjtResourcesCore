

namespace XJTResourcesCore.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Email : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public int EmailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Category Category { get; set; }
    }
}