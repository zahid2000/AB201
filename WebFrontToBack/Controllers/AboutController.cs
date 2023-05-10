using Microsoft.AspNetCore.Mvc;

namespace WebFrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
