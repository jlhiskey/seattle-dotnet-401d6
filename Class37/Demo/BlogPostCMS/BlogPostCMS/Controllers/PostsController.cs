using Microsoft.AspNetCore.Mvc;

namespace BlogPostCMS.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
