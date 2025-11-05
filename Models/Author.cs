using System.ComponentModel.DataAnnotations;

namespace Pricope_Delia_L2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Author's Last Name")]
        public string? LastName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
