using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "costomer needs a name")]
        [StringLength(30, ErrorMessage = "namnet får inte vara längre än 30 tecken")]
        public string Name { get; set; }
        [Required(ErrorMessage = "costomer needs an email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Customer needs an Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Customer needs an address")]
        public string Address { get; set; }
        public ICollection<BookLoan>? BookLoans { get; set; }

    }
}
