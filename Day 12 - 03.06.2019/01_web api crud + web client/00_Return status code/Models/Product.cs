using System.ComponentModel.DataAnnotations;

namespace ProductServer.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required,MinLength(2),MaxLength(9)]
        public string name { get; set; }

        [Required,Range(1, 500), ZugiValidator]
        public double price { get; set; }

    }
}