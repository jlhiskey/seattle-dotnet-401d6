using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week4MVCReview.Models.Interfaces
{
    public interface ICourse
    {
        // create
        Task CreateCourse(Course course);
        //read
        List<Course> GetCourses();

        //update

        //delete
    }
}
