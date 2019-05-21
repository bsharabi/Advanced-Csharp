using System.ComponentModel.DataAnnotations;

namespace _01_BOL
{
    public class BookModel
    {
        [Required, MinLength(2), MaxLength(15)]
        public string BookName { get; set; }

        [Required, Range(30, 200)]
        public decimal BookPrice { get; set; }

        [Required]
        public AuthorModel BookAuthor { get; set; }

    }
}
