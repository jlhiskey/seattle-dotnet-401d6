using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudentEnrollment.Models.Interfaces
{
    public interface IStudentManager
    {
        // Create a student
       Task CreateStudent(Student student);

        // Read a student

        Task<Student> GetStudent(int id);

        Task<IEnumerable<Student>> GetStudents();

        // update/edit a student
        void UpdateStudent(Student student);

        // delete a student

        void DeleteStudent(int id);
    }
}
