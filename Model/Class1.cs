using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata.Ecma335;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }
        public IFormFile Photo { get; set; }
        public string Description { get; set; }
    }
}