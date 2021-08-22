using StudentManagement.Domain;
using StudentManagement.Domain.Results;
using StudentManagement.Domain.Results.Student;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services.Interfaces
{
    public interface IStudentService
    {
        Task<List<ApplicationUser>> GetStudents();

        Task<StudentAuthenticationResult> GetStudentByIdAsync(string studentId);

        Task<StudentAuthenticationResult> GetStudentByUsernameAsync(string studentUsername);

        Task<bool> UpdateStudentAsync(ApplicationUser studentToUpdate);

        Task<bool> DeleteStudentAsync(string studentToDelete);

        Task<bool> AddCourseToStudentByIdAsync(string studentId, string courseId);

        Task<bool> DeleteCourseFromStudentByIdAsync(string studentId, string courseId);

        Task<Student> GetCourseFromStudentByIdAsync(string studentId);

        Task<List<Student>> getAllCourseAndStudentAsync();
    }
}
