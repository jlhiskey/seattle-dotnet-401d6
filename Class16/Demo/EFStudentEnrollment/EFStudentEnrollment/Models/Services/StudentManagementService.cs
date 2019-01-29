using EFStudentEnrollment.Data;
using EFStudentEnrollment.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudentEnrollment.Models.Services
{
    public class StudentManagementService : IStudentManager
    {
        private SchoolEnrollmentDbContext _context { get; }

        public StudentManagementService(SchoolEnrollmentDbContext context)
        {
            _context = context;
        }

        public async Task CreateStudent(Student student)
        {
            _context.Students.Add(student);
           await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public void DeleteStudent(int id)
        {
            Student student = _context.Students.FirstOrDefault(s => s.ID == id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(student => student.ID == id);
            
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
        }

    }
}
