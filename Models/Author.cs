namespace Pricope_Delia_L2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string? AuthorName { get; set; }
        public ICollection<Author>? Authors { get; set; } //navigation property
    }
}
