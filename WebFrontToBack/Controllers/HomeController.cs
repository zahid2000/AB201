using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebFrontToBack.DAL;
using WebFrontToBack.ViewModel;

namespace WebFrontToBack.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            HttpContext.Session.SetString("name", "Ali");
            Response.Cookies.Append("surname", "Seferli",new CookieOptions {MaxAge=TimeSpan.FromSeconds(15)});
            HomeVM homeVM = new HomeVM()
            {
                Categories = await _appDbContext.Categories.Where(c => !c.IsDeleted).ToListAsync()
                //Services = await _appDbContext.Services.Where(c => !c.IsDeleted)
                //.Include(s=>s.Category)
                //.Include(s=>s.ServiceImages)
                //.ToListAsync()
            };
            return View(homeVM);
        }

       
    }
}
