using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain;
using StudentManagement.Domain.Results;
using StudentManagement.Domain.Results.Student;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly UserManager<ApplicationUser> _dataContext;
        private readonly ApplicationDBContext _applicationDBContext;

        public StudentService(UserManager<ApplicationUser> dataContext, ApplicationDBContext applicationDBContext)
        {
            _dataContext = dataContext;
            _applicationDBContext = applicationDBContext;
        }

        public async Task<List<ApplicationUser>> GetStudents()
        {
            //_applicationDBContext.Users.Include(x => x.course)
            //return _dataContext.Users.Where(x => x.UserType == "Student");

            return await _dataContext.Users.Include(x => x.course).Where(x => x.UserType == "Student").ToListAsync();
        }

        public async Task<StudentAuthenticationResult> GetStudentByIdAsync(string studentId)
        {
            var user = await _dataContext.Users.Include(x => x.course).Where(x => (x.UserType == "Student") && (x.Id.ToUpper() == studentId.ToUpper())).FirstOrDefaultAsync();
            //var user = await _dataContext.FindByIdAsync(studentId);

            //check to make sure that the ID is not an administrator
            if (user == null)
            {
                return new StudentAuthenticationResult { Errors = new[] { "Student does not exist" } };
            }
            return new StudentAuthenticationResult { User = user, Success = true };
        }

        public async Task<StudentAuthenticationResult> GetStudentByUsernameAsync(string studentUsername)
        {

            var user = await _dataContext.Users.Include(x => x.course).Where(x => (x.UserType == "Student") && (x.UserName.ToUpper() == studentUsername.ToUpper())).FirstOrDefaultAsync();

            //check to make sure that the ID is not an administrator
            if (user == null)
            {
                return new StudentAuthenticationResult { Errors = new[] { "Student does not exist" } };
            }
            return new StudentAuthenticationResult { User = user, Success = true };
        }

        public async Task<bool> UpdateStudentAsync(ApplicationUser studentToUpdate)
        {
            var updated = await _dataContext.UpdateAsync(studentToUpdate);
            return updated.Succeeded;
        }

        public async Task<bool> DeleteStudentAsync(string studentToDelete)
        {
            var user = await _dataContext.FindByIdAsync(studentToDelete);

            if (user == null) return false;
            var deleted = await _dataContext.DeleteAsync(user);
            return deleted.Succeeded;
        }



        public async Task<bool> AddCourseToStudentByIdAsync(string studentId, string courseId)
        {
            //Check if subject doesnt exist already
            var user = await _dataContext.FindByIdAsync(studentId);
            if (user == null) return false;

            var course = await _applicationDBContext.Courses.SingleOrDefaultAsync(x => x.CourseId == courseId);
            if (course == null) return false;

            user.course = course;
      
            var result = await _applicationDBContext.SaveChangesAsync();
            return result > 0;

        }

        public async Task<bool> DeleteCourseFromStudentByIdAsync(string studentId, string courseId)
        {
            var user = await _dataContext.FindByIdAsync(studentId);
            if (user == null) return false;

            var course = await _applicationDBContext.Courses.SingleOrDefaultAsync(x => x.CourseId == courseId);
            if (course == null) return false;

            var data = _applicationDBContext.Users.Include(x => x.course)
                .Where(x => x.Id == studentId)
                .FirstOrDefault();

            data.course = null;
            var result = await _applicationDBContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<Student> GetCourseFromStudentByIdAsync(string studentId)
        {
            var data = _applicationDBContext.Users.Include(x => x.course)
                .Where(x => x.Id == studentId)
                .Select(x => new Student { Id = x.Id, Email = x.Email, UserName = x.UserName, course = x.course, CourseId = x.CourseId, TimeStamp = x.TimeStamp, UserType = x.UserType })
                .FirstOrDefault();
            var result = await _applicationDBContext.SaveChangesAsync();

            return data;
        }

        public async Task<List<Student>> getAllCourseAndStudentAsync()
        {
            var data = await _applicationDBContext.Users.Include(x => x.course)
                .Select(x => new Student { Id = x.Id, Email = x.Email, UserName = x.UserName, course = x.course, CourseId = x.CourseId, TimeStamp = x.TimeStamp, UserType = x.UserType})
                .ToListAsync();
            var result = await _applicationDBContext.SaveChangesAsync();

            return data;
        }
    }
}
