using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFStudentEnrollment.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please provide a name")]
        [Display(Name="Name of course")]
        public string Name { get; set; }

        [Display(Name="Tech Stack:")]
        public Tech Technology { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        // Navigation Properties
        public ICollection<CourseEnrollments> Students { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }

    }

    public enum Tech
    {
        [Display(Name=".NET")]
        DotNet,
        Java,
        JavaScript,
        Python
    }
}
