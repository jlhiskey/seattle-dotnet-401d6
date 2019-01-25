using System.Collections.Generic;

namespace EFStudentEnrollment.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Tech Technology { get; set; }
        public decimal Price { get; set; }

        // Navigation Properties
        public ICollection<CourseEnrollments> Students { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }

    }

    public enum Tech
    {
        DotNet,
        Java,
        JavaScript,
        Python
    }
}
