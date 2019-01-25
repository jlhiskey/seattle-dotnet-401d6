using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudentEnrollment.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public ICollection<Transcript> Transcripts { get; set; }

        public ICollection<CourseEnrollments> Courses { get; set; }
    }
}
