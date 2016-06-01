namespace XJTResourcesCore.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Faq : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public Faq()
        {

        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int FaqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ContractSection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsHTML { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Html { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        public virtual Category Category { get; set; }
    }
}