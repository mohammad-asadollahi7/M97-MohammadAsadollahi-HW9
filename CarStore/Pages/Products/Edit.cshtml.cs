using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Abstract;

namespace CarStore.Pages.Products;

public class EditModel : PageModel
{
    private readonly IProductRepository _productRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public EditModel(IProductRepository productRepository, IWebHostEnvironment webHostEnvironment)
    {
        _productRepository = productRepository;
        _webHostEnvironment = webHostEnvironment;
    }
    [BindProperty]
    public Product product { get; set; }
    public IActionResult OnGet(int id)
    {
        product = _productRepository.GetProductById(id);
        return Page();
    }
    [BindProperty]
    public IFormFile Photo { get; set; }
    public IActionResult OnPost()
    {
        if (Photo != null)
        {
            if (product.PhotoPath != null)
            {
                var fullPath = Path.Combine(_webHostEnvironment.WebRootPath,
                                              "Photo", product.PhotoPath);
                System.IO.File.Delete(fullPath);
            }
            product.PhotoPath = ProcessPhoto();
        }
        _productRepository.Update(product);
        return RedirectToPage("Index");
    }

    private string? ProcessPhoto()
    {
        string? fileName = null;
        if (Photo != null)
        {
            var folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "Photo");
            fileName = Path.Combine(Guid.NewGuid().ToString() + "_" + Photo.FileName);
            var filePath = Path.Combine(folderPath, fileName);
            using(var fs = new FileStream(filePath, FileMode.Create))
            {
                Photo.CopyTo(fs);
            }
        }
        return fileName;

    }
}
