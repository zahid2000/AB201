using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.DAL;
using WebFrontToBack.Services;

namespace WebFrontToBack.ViewComponents;

public class HeaderViewComponent:ViewComponent
{
    private readonly AppDbContext _context;
    private readonly LayoutService _layoutService;

    public HeaderViewComponent(AppDbContext context, LayoutService layoutService)
    {
        _context = context;
        _layoutService = layoutService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await _layoutService.GetSettingsAsync());
    }
}
