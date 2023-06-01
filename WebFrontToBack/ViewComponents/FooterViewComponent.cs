using Microsoft.AspNetCore.Mvc;
using WebFrontToBack.DAL;
using WebFrontToBack.Services;

namespace WebFrontToBack.ViewComponents;

public class FooterViewComponent : ViewComponent
{
    private readonly AppDbContext _context;
    private readonly LayoutService _layoutService;

    public FooterViewComponent(AppDbContext context, LayoutService layoutService)
    {
        _context = context;
        _layoutService = layoutService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await _layoutService.GetSettingsAsync());
    }
}
