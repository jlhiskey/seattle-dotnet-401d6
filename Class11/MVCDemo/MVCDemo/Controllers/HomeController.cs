using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // returns the view in the Views >> Home >> Index.cshtml location
            return View();
        }

        [HttpPost]
        public IActionResult Index(string firstName, string lastName)
        {
            return RedirectToAction("Results", new { firstName, lastName });
        }

        public IActionResult Results(string firstName, string lastName)
        {
            Student student = new Student(firstName, lastName);
            return View(student);
        }
    }
}
