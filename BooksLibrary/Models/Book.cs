using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage = "book needs a title")]
        [StringLength(50, ErrorMessage = "namnet får inte vara längre än 50 tecken")]
        public string Title { get; set; }
        [Required(ErrorMessage = "the book needs a type")]
        [StringLength(30, ErrorMessage = "namnet får inte vara längre än 30 tecken")]
        public string Type { get; set; }
        [Required(ErrorMessage = "the book needs a author")]
        public string Author { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Released { get; set; }
        public ICollection<BookLoan>? BookLoans { get; set; }
    }
}
