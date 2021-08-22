using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Domain;
using StudentManagement.Models;

namespace StudentManagement.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllCourseAsync();

        Task<Course> GetCourseByIdAsync(string courseId);

        Task<Course> GetCourseByNameAsync(string courseName);

        Task<bool> DeleteCourseAsync(string courseId);

        Task<bool> UpdateCourseAsync(Course course);

        Task<bool> CreateCourseAsync(Course course);

        
        Task<Course> getSubjectFromCourseAsync(string courseId);

        Task<List<Course>> getAllSubjectAndCourseAsync();

        Task<bool> addSubjectToCourseAsync(string courseId, string subjectId);

        Task<bool> deleteSubjectFromCourseAsync(string courseId, string subjectId);


        Task<Course> getStudentFromCourseAsync(string studentId);

        Task<List<Course>> getAllStudentAndCourseAsync();

        Task<bool> addStudentToCourseAsync(string courseId, string studentId);

        Task<bool> deleteStudentFromCourseAsync(string courseId, string studentId);


    }
}
