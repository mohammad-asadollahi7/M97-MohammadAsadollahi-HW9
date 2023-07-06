using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CarStore.Pages.Products;

public class EditModel : PageModel
{
    private readonly IProductRepository _productRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public EditModel(IProductRepository productRepository,
                        IWebHostEnvironment webHostEnvironment)
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

    [Required]
    [BindProperty]
    public IFormFile? Photo { get; set; }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            string fileName = null;
            if (Photo != null)
            {
                if (product.PhotoPath != null)
                {
                    fileName = product.PhotoPath;
                    var fullPath = Path.Combine(_webHostEnvironment.WebRootPath,
                                                  "Photo", product.PhotoPath);
                    System.IO.File.Delete(fullPath);
                }
                product.PhotoPath = ProcessPhoto(fileName);
            }
            _productRepository.Update(product);
            return RedirectToPage("Index");
        }

        return Page();

    }

    [BindProperty]
    public bool Notify { get; set; }


    public string Message { get; set; }
    public IActionResult OnPostNotification(int id)
    {
        if (Notify)
        {
            Message = "Notification is activated";
        }
        else
        {
            Message = "Notification is off";
        }
        TempData["message"] = Message;
        return RedirectToPage("Details", new { id = id });
    }

    private string ProcessPhoto(string? fileName)
    {
        fileName = fileName ?? Photo.FileName;
        var folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "Photo");
        var filePath = Path.Combine(folderPath, fileName);
        using (var fs = new FileStream(filePath, FileMode.Create))
        {
            Photo.CopyTo(fs);
        }

        return fileName;

    }
}
