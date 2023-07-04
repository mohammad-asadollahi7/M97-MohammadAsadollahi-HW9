using Model;
using Services.Abstract;

namespace Services.Services
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}