using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services.Interfaces
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetAllSubjectAsync();

        Task<Subject> GetSubjectByIdAsync(string subjectId);

        Task<Subject> GetSubjectByNameAsync(string subjectId);

        Task<bool> DeleteSubjectAsync(string subjectId);

        Task<bool> UpdateSubjectAsync(Subject subject);

        Task<bool> CreateSubjectAsync(Subject subject);

        Task<Subject> getCourseFromSubjectAsync(string subjectId);

        Task<List<Subject>> getAllCourseAndSubjectAsync();

        Task<bool> addCourseToSubjectAsync(string subjectId, string courseId);

        Task<bool> deleteCourseFromSubjectAsync(string subjectId, string courseId);
    }
}
