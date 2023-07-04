using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Name: ")]
        public string Name { get; set; }

        public string Barcode { get; set; }

        [Display(Name = "Price: ")]
        public decimal Price { get; set; }

        public string PhotoPath { get; set; }

        [Display(Name = "Description: ")]
        public string Description { get; set; }
    }
}