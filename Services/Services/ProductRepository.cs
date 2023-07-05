using Data;
using Model;
using Services.Abstract;

namespace Services.Services;

public class ProductRepository : IProductRepository
{
    private readonly ProductData _data;
    public ProductRepository(ProductData data)
    {
        _data = data;
    }
    public IEnumerable<Product> GetAllProduct()
    {
        return _data.products;
    }

    public Product GetProductById(int id)
    {
        var product = _data.products.FirstOrDefault(u => u.Id == id);
        if (product == null)
        {
            return null;
        }
        else
        {
            return product;
        }
    }

    public void Update(Product updatedProduct)
    {
        var oldProduct = _data.products.FirstOrDefault(p => p.Id == updatedProduct.Id);
        oldProduct = updatedProduct;
        _data.products[oldProduct.Id -1] = oldProduct;
    }

    public void Delete(Product product)
    {
        _data.products.Remove(product);
    }
}