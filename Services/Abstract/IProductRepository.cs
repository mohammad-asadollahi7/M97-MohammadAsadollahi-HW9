using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProduct();
    Product GetProductById(int id);

}
