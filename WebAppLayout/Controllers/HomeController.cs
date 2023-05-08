using Microsoft.AspNetCore.Mvc;
using WebAppLayout.Models;
using WebAppLayout.ViewModels;

namespace WebAppLayout.Controllers
{
    public class HomeController : Controller
    {
        public List<Student> Students =new List<Student>()
        {
            new Student
            {
                Id=1,
                Name="Muslum",
                Surname="Misirli"
            },
            new Student
            {
                Id=2,
                Name="Hikmet",
                Surname="Mehraliyev"
            },
            new Student
            {
                Id=3,
                Name="Eli",
                Surname="Tagizade"
            },
            new Student
            {
                Id=4,
                Name="Vaqif",
                Surname="Yaqubov"
            },
            new Student
            {
                Id=5,
                Name="Cosqun",
                Surname="Salahov"
            }
        };
        public string[] Groups = { "AB201", "AB202", "BB201" };
        public IActionResult Index()
        {

            //ViewBag.Name = "Eli";
            //ViewData["Name"] = "Eli";
            //TempData["Surname"] = "Seferli";
            //return RedirectToAction(nameof(Show));
            //TempData["Students"] = Students;

            //Tuple
            //(List<Student>, string[]) homeTuple = (Students, Groups);

            //ViewModel
            HomeVM homeVM = new HomeVM() { Students=Students,Groups=Groups};


            return View(homeVM);
        }
        public IActionResult Show()
        {           
            return View();
        }
    }
}
