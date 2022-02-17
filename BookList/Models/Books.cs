using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookList.Models
{
    public class Books
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }


        [Display(Name = "Author")]
        public string? AuthorLast { get; set; }

        [Display(Name = "First")]
        public string? AuthorFirst { get; set; }


        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        public string? Rating { get; set; } //Added this after building the inital model, to show adding database fields -> also updating bind attribute in the controller BooksController.cs, line 96, and Books/index.cshtml Books/create.cshtml, Books/Details.cshtml.  You also need to do a database migration/update for this to take effect 
    }
}
