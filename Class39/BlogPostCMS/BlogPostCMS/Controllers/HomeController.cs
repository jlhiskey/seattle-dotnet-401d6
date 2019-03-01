using BlogPostCMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BlogPostCMS.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(bool works = true)
        {
            Payment payment = new Payment(_configuration);
            string answer = payment.Run();

            if (answer == "OK")
            {
                return View();
            }
            else
            {
                return View();
            }

        }



    }
}
