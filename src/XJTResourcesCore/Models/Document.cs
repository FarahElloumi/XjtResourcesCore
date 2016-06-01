namespace XJTResourcesCore.Models
{
    public class Document : BaseClass
    {
        public Document()
        {
            base.IsActive = false;
        }

        public int DocumentId { get; set; }
        public string DocTitle { get; set; }
        public string Path { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }


        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}