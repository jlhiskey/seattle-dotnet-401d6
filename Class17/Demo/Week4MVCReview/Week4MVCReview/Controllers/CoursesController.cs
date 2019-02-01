using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Week4MVCReview.Models;
using Week4MVCReview.Models.Interfaces;

namespace Week4MVCReview.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourse _courses;

        public CoursesController(ICourse courses)
        {
            _courses = courses;
        }

        // GET: Courses
        public IActionResult Index()
        {
            return View(_courses.GetCourses());
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Price")] Course course)
        {
            if (ModelState.IsValid)
            {
                await _courses.CreateCourse(course);
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }
    }
}
