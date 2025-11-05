using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Pricope_Delia_L2.Models
{
    public class Book
    {
        public int ID { get; set; }

        //Definim titlul
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        //Definim autorul
        public int? AuthorID { get; set; }
        public Author? Author { get; set; } //navigation property

        //Definim pretul
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        //Definim editura
        [Display(Name = "Publishing Date")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }//navigation property
    } 
}

