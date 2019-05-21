using System.ComponentModel.DataAnnotations;

namespace _01_BOL
{
    public class AuthorModel
    {
        [Required, Range(18,120)]
        public int AuthorAge { get; set; }

        [Required, MinLength(3),MaxLength(20)]
        public string AuthorName { get; set; }

        [Required, MinLength(5)]
        public string AuthorImage { get; set; }

    }
}
