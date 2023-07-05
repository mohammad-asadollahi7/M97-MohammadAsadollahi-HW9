using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Abstract;

namespace CarStore.Pages.Products;

public class DeleteModel : PageModel
{
    private readonly IProductRepository _productRepository;
    public DeleteModel(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public Product product { get; set; }
    public IActionResult OnGet(int id)
    {
        product = _productRepository.GetProductById(id);
        if (product == null)
        {
            return RedirectToPage("/NotFound");
        }
        return Page();
    }

    public IActionResult OnPost(int id)
    {
        product = _productRepository.GetProductById(id);
        _productRepository.Delete(product);
        return RedirectToPage("Index");
    }
}
