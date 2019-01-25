using EFStudentEnrollment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudentEnrollment.Data
{
    public class SchoolEnrollmentDbContext : DbContext
    {
        public SchoolEnrollmentDbContext(DbContextOptions<SchoolEnrollmentDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add our composite key associations
            modelBuilder.Entity<CourseEnrollments>().HasKey(ce => new { ce.CourseID, ce.StudentID });
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }


    }
}
