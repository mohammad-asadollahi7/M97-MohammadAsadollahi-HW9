using Model;

namespace Data;

public class ProductData
{
    public List<Product> products = new List<Product>()
    {
        new Product()
        {
            Id = 1,
            Barcode = "4054dtf",
            Name="Mercedes A class",
            Price=1000000,
            Description = "The Mercedes-Benz A-Class is a subcompact " +
                            "car produced by the German automobile manufacturer " +
                            "Mercedes-Benz as the brand's entry-level vehicle",
            PhotoPath = "benz.jpg"
        },

        new Product()
        {
        Id = 2,
            Barcode = "1054jtf",
            Name = "Audi A1",
            Price = 1040000,
            Description = "The Audi A1 (internally designated Typ 8X) is a supermini " +
                            "car launched by Audi at the 2010 Geneva Motor Show",
            PhotoPath = "audi.jpg"
        },


        new Product()
        {
            Id = 3,
            Barcode = "453atm",
            Name="BMW 2 Gran Tourer",
            Price=1080000,
            Description = "The BMW 2 Series is a range of subcompact " +
                            "executive cars (C-segment) manufactured by BMW since 2014",
            PhotoPath = "BMW.jpg"
        },

        new Product()
        {
            Id = 4,
            Barcode = "4013atm",
            Name="Chevrolet Camaro",
            Price=1180000,
            Description = "The Chevrolet Camaro is a mid-size[1][2] American " +
                          "automobile manufactured by Chevrolet, classified as a pony car",
            PhotoPath = "Chevrolet.jpg"
        }

    };
}