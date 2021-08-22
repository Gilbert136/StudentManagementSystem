using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDBContext _dataContext;
        
        public CourseService(ApplicationDBContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> CreateCourseAsync(Course course)
        {
            //check if course already exist
            var data = await _dataContext.Courses.AddAsync(course);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteCourseAsync(string courseId)
        {
            var course = await GetCourseByIdAsync(courseId);
            if (course == null) return false;

            var data = _dataContext.Courses.Remove(course);

            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<List<Course>> GetAllCourseAsync()
        {
            return await _dataContext.Courses.ToListAsync();
        }

        public async Task<bool> UpdateCourseAsync(Course course)
        {
            var courseResult = await GetCourseByIdAsync(course.CourseId);
            if (courseResult == null) return false;

            courseResult.Name = course.Name;

            var data = _dataContext.Courses.Update(courseResult);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }
        
        public async Task<Course> GetCourseByIdAsync(string courseId)
        {
            //i have to customize the return, reference studentService.GetStudentByIdAsync
            return await _dataContext.Courses.Include(x => x.ApplicationUsers).Include(x => x.Subjects).SingleOrDefaultAsync(x => x.CourseId == courseId);
        }

        public async Task<Course> GetCourseByNameAsync(string courseName)
        {
            //i have to customize the return, reference studentService.GetStudentByIdAsync
            return await _dataContext.Courses.Include(x => x.ApplicationUsers).Include(x => x.Subjects).SingleOrDefaultAsync(x => x.Name.ToUpper() == courseName.ToUpper());
        }



        public async Task<Course> getSubjectFromCourseAsync(string courseId)
        {
            var data = _dataContext.Courses.Include(x => x.Subjects)
                .Where(x => x.CourseId == courseId).FirstOrDefault();

            var result = await _dataContext.SaveChangesAsync();

            return data;               
        }

        public async Task<bool> addSubjectToCourseAsync(string courseId, string subjectId)
        {
            //Check if subject doesnt exist already
            var course = await GetCourseByIdAsync(courseId);
            if (course == null) return false;

            var subject = await _dataContext.Subjects.SingleOrDefaultAsync(x => x.SubjectId == subjectId);
            if (subject == null) return false;

            //var data = _dataContext.Courses
            //    .Include(x => x.Subjects)
            //    .Where(x => x.CourseId == courseId)
            //    .FirstOrDefault();

            course.Subjects.Add(subject);


            var result = await _dataContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> deleteSubjectFromCourseAsync(string courseId, string subjectId)
        {
            var course = await GetCourseByIdAsync(courseId);
            if (course == null) return false;

            var subject = await _dataContext.Subjects.SingleOrDefaultAsync(x => x.SubjectId == subjectId);
            if (subject == null) return false;

            var data = _dataContext.Courses.Include(x => x.Subjects)
                .Where(x => x.CourseId == courseId)
                .FirstOrDefault();

            data.Subjects.Remove(subject);

            var result = await _dataContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<List<Course>> getAllSubjectAndCourseAsync()
        {
            var data = await _dataContext.Courses.Include(x => x.Subjects).ToListAsync();
            var result = await _dataContext.SaveChangesAsync();

            return data;
        }



        public async Task<Course> getStudentFromCourseAsync(string courseId)
        {
            var data = _dataContext.Courses.Include(x => x.ApplicationUsers)
                .Where(x => x.CourseId == courseId).FirstOrDefault();

            var result = await _dataContext.SaveChangesAsync();

            return data;
        }

        public async Task<List<Course>> getAllStudentAndCourseAsync()
        {
            var data = await _dataContext.Courses.Include(x => x.ApplicationUsers)
                .Select(x => new Course { Name = x.Name, CourseId = x.CourseId, Subjects = x.Subjects, ApplicationUsers = x.ApplicationUsers })
                .ToListAsync();
            var result = await _dataContext.SaveChangesAsync();

            return data;
        }

        public async Task<bool> addStudentToCourseAsync(string courseId, string studentId)
        {
            //Check if subject doesnt exist already
            var course = await GetCourseByIdAsync(courseId);
            if (course == null) return false;

            var student = await _dataContext.Users.SingleOrDefaultAsync(x => x.Id == studentId);
            if (student == null) return false;

            course.ApplicationUsers.Add(student);

            var result = await _dataContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> deleteStudentFromCourseAsync(string courseId, string studentId)
        {
            var course = await GetCourseByIdAsync(courseId);
            if (course == null) return false;

            var student = await _dataContext.Users.SingleOrDefaultAsync(x => x.Id == studentId);
            if (student == null) return false;

            var data = _dataContext.Courses.Include(x => x.ApplicationUsers)
                .Where(x => x.CourseId == courseId)
                .FirstOrDefault();

            data.ApplicationUsers.Remove(student);

            var result = await _dataContext.SaveChangesAsync();

            return result > 0; ;
        }
    }
}
