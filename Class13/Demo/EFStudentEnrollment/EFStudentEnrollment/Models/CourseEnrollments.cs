using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudentEnrollment.Models
{
    public class CourseEnrollments
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        // Navigation Properties

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
