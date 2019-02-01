using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week4MVCReview.Data;
using Week4MVCReview.Models.Interfaces;

namespace Week4MVCReview.Models.Services
{
    public class CourseService : ICourse
    {
        private DemoDbContext _context;

        public CourseService(DemoDbContext context)
        {
            _context = context;
        }
        public async Task CreateCourse(Course course)
        {
            // Add the course to the database/dataset that holds the course information
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }


    }
}
