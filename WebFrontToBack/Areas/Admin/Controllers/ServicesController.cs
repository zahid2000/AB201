using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.Areas.Admin.ViewModels;
using WebFrontToBack.DAL;
using WebFrontToBack.Models;
using WebFrontToBack.Utilities.Constants;
using WebFrontToBack.Utilities.Extensions;

namespace WebFrontToBack.Areas.Admin.Controllers;
[Area("Admin")]
public class ServicesController : Controller
{
    private readonly AppDbContext _context;
    private List<Category> _categories;
    private readonly IWebHostEnvironment _enviroment;
    private string _errorMessages;
    public ServicesController(AppDbContext context, IWebHostEnvironment enviroment)
    {
        _context = context;
        _categories = _context.Categories.ToList();
        _enviroment = enviroment;
    }

    public async Task<IActionResult> Index(int page=1,int take=8)
    {
        List<Service> services = await _context.Services
            .Where(s => !s.IsDeleted)
            .OrderByDescending(s => s.Id)
            .Skip((page - 1) * take)
            .Take(take)
            .Include(s => s.Category)
            .Include(s => s.ServiceImages)
            .ToListAsync();
        int pageCount = await GetPageCount(take);

        PaginateVM<Service> model = new PaginateVM<Service>
        {
            Data = services,
            CurrentPage = page,
            PageCount = pageCount,
            HasNext = page < pageCount,
            HasPreview = page > 1,
            Take=take
        };

        return View(model);
    }

    private async Task<int> GetPageCount(int take)
    {
        int serviceCount=await _context.Services.CountAsync();
        return (int)Math.Ceiling((double)serviceCount / take);
    }

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create()
    {
        CreateServiceVm createServiceVm = new CreateServiceVm()
        {
            Categories = _categories
        };
        return View(createServiceVm);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [ValidateAntiForgeryToken]
  
    public async Task<IActionResult> Create(CreateServiceVm serviceVm)
    {
        serviceVm.Categories = _categories;
        if (!ModelState.IsValid) return View(serviceVm);
        if (!CheckPhoto(serviceVm.Photos)) ModelState.AddModelError("Photos", _errorMessages);
        string rootPath = Path.Combine(_enviroment.WebRootPath, "assets", "img");
        List<ServiceImage> images = await CreateFileAndGetServiceImages(serviceVm.Photos, rootPath);
        Service service = new Service()
        {
            Name = serviceVm.Name,
            CategoryId = serviceVm.CategoryId,
            Description = serviceVm.Description,
            Price = serviceVm.Price,
            ServiceImages = images
        };
        await _context.Services.AddAsync(service);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private  async Task<List<ServiceImage>> CreateFileAndGetServiceImages(List<IFormFile> photos, string rootPath)
    {
        List<ServiceImage> images = new List<ServiceImage>();
        foreach (var photo in photos)
        {
            string fileName = await photo.SaveAsync(rootPath);
            ServiceImage serviceImage = new ServiceImage() { Path = fileName };
            if (!images.Any(i => i.IsActive))
            {
                serviceImage.IsActive = true;
            }
            images.Add(serviceImage);
        }

        return images;
    }

    private bool CheckPhoto(List<IFormFile> photos)
    {
        foreach (var photo in photos)
        {
            if (!photo.CheckContentType("image/"))
            {
                _errorMessages= $"{photo.FileName} - {Messages.FileTypeMustBeImage}";
                return false;
            }
            if (!photo.CheckFileSize(200))
            {
               _errorMessages= $"{photo.FileName} - {Messages.FileSizeMustBe200KB}";
                return false;
            }
        }
        return true;
    }
}
