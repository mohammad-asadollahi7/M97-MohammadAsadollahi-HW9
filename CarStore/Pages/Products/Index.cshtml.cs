using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Abstract;

namespace CarStore.Pages.Products;

public class IndexModel : PageModel
{
    private readonly IProductRepository _productRepository;

    public IndexModel(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public List<Product> Products { get; set; }
    public void OnGet()
    {
       Products = _productRepository.GetAllProduct().ToList();
    }
}
