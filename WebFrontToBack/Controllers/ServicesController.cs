using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.DAL;
using WebFrontToBack.Models;

namespace WebFrontToBack.Controllers
{
    public class ServicesController : Controller
    {
        protected readonly AppDbContext _context;

        public ServicesController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.dbServiceCount=await _context.Services.CountAsync();

            return View();
        }

        public async Task<IActionResult> LoadMore(int skip=0,int take=8)
        {

            //List<Service> services = await _context.Services
            //    .OrderByDescending(s => s.Id)
            //    .Where(s => !s.IsDeleted)
            //    .Skip(skip)
            //    .Take(take)
            //    .Include(s => s.ServiceImages)
            //    .ToListAsync();
            //return PartialView("_ServicesPartialView",services);

            return ViewComponent("Service",new {skip=skip,take=take});
        }
        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("name");
            string surname = Request.Cookies["surname"];
            return Json(name+" "+surname);
        }
    }
}
