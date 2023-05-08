using Microsoft.AspNetCore.Mvc;

namespace WebFirstApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(int id)
        {
            //ViewResult view=new ViewResult();
            //view.ViewName = "Index";
            //return view;

            //if (id == 1)
            //{
            //    return View();
            //}else if (id ==2)
            //{
            //    return Content("AB201");

            //}
            //return Json(new
            //{
            //    name="Eli",
            //    surname="Seferli"
            //});
            return View();
        }

        public ViewResult About()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "About";
            return view;
        }
    }
}
