using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ApplicationDBContext _dataContext;

        public SubjectService(ApplicationDBContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> CreateSubjectAsync(Subject subject)
        {
            //check if course already exist
            var data = await _dataContext.Subjects.AddAsync(subject);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteSubjectAsync(string subjectId)
        {
            var subject = await GetSubjectByIdAsync(subjectId);

            if (subject == null) return false;
            var data = _dataContext.Subjects.Remove(subject);

            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<List<Subject>> GetAllSubjectAsync()
        {
            return await _dataContext.Subjects.Include(x => x.course).ToListAsync();
        }

        public async Task<bool> UpdateSubjectAsync(Subject subject)
        {
            var subjectResult = await GetSubjectByIdAsync(subject.SubjectId);
            if (subjectResult == null) return false;

            subjectResult.Name = subject.Name;

            var data = _dataContext.Subjects.Update(subjectResult);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<Subject> GetSubjectByIdAsync(string subjectId)
        {
            return await _dataContext.Subjects.Include(x => x.course).SingleOrDefaultAsync(x => x.SubjectId == subjectId);
        }

        public async Task<Subject> GetSubjectByNameAsync(string subjectId)
        {
            return await _dataContext.Subjects.Include(x => x.course).SingleOrDefaultAsync(x => x.Name.ToUpper() == subjectId.ToUpper());
        }

        public async Task<Subject> getCourseFromSubjectAsync(string subjectId)
        {
            return await _dataContext.Subjects.SingleOrDefaultAsync(x => x.SubjectId == subjectId);
        }

        public async Task<List<Subject>> getAllCourseAndSubjectAsync()
        {
            var data = await _dataContext.Subjects.Include(x => x.course)
                //.Select(x => new { subjectId = x.SubjectId, name = x.Name, courseId = x.CourseId, courseName = x.course.Name })
                .ToListAsync();
            var result = await _dataContext.SaveChangesAsync();

            return data;
        }

        public async Task<bool> addCourseToSubjectAsync(string subjectId, string courseId)
        {
            //Check if subject doesnt exist already
            var subject = await GetSubjectByIdAsync(subjectId);
            if (subject == null) return false;

            var course = await _dataContext.Courses.SingleOrDefaultAsync(x => x.CourseId == courseId);
            if (course == null) return false;

            //for better optimization make reference to courseService.AddSubjectToCourse
            var data = _dataContext.Subjects.Include(x => x.course)
                .Where(x => x.SubjectId == subjectId)
                .FirstOrDefault();

            data.course = course;

            var result = await _dataContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> deleteCourseFromSubjectAsync(string subjectId, string courseId)
        {
            var subject = await GetSubjectByIdAsync(subjectId);
            if (subject == null) return false;

            var course = await _dataContext.Courses.SingleOrDefaultAsync(x => x.CourseId == courseId);
            if (course == null) return false;

            var data = _dataContext.Subjects.Include(x => x.course)
                .Where(x => x.SubjectId == subjectId)
                .FirstOrDefault();

            data.course = null;

            var result = await _dataContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
