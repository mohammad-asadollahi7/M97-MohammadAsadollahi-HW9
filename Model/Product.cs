using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Name: ")]
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters")]
        [Required]
        public string? Name { get; set; }

        public string? Barcode { get; set; }

        [Display(Name = "Price: ")]
        [Required]
        public decimal? Price { get; set; }

        public string? PhotoPath { get; set; }

        [Display(Name = "Description: ")]
        [MaxLength(200)]
        [Required]
        public string? Description { get; set; }
    }
}