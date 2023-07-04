using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Abstract;

namespace CarStore.Pages.Products;

public class EditModel : PageModel
{
    private readonly IProductRepository _productRepository;
    public EditModel(IProductRepository productRepository)
    {
        _productRepository = productRepository;

    }
    public Product product { get; set; }
    public void OnGet(int id)
    {
        product = _productRepository.GetProductById(id);
    }
}
