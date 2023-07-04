using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Abstract;
using Services.Services;

namespace CarStore.Pages.Products;

public class DetailsModel : PageModel
{
    private IProductRepository _productRepository;

    public DetailsModel(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Product product { get; set; }
    public void OnGet(int id)
    {
        product = _productRepository.GetProductById(id);
    }
}
