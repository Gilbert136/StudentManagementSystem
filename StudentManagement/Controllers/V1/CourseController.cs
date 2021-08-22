using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Contracts.V1;
using StudentManagement.Contracts.V1.Requests.CourseRequest;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet(ApiRoutes.Course.GetAll)]
        public async Task<IActionResult> GetCourses()
        {
            var courses = await _courseService.GetAllCourseAsync();

            if (courses == null)
                return NotFound();

            return Ok(courses);
        }

        [HttpGet(ApiRoutes.Course.Get)]
        public async Task<IActionResult> Get([FromRoute] string courseId)
        {
            var courseWithNameResult = await _courseService.GetCourseByNameAsync(courseId);
            if (courseWithNameResult == null)
            {
                var courseWithIdResult = await _courseService.GetCourseByIdAsync(courseId);
                if (courseWithIdResult == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(courseWithIdResult);
                }
            }
            else {
                return Ok(courseWithNameResult);
            }                 
        }

        [HttpPut(ApiRoutes.Course.Update)]
        public async Task<IActionResult> UpdateCourse([FromRoute] string courseId, [FromBody] CourseUpdateRequest updateRequest)
        {
            var course = await _courseService.GetCourseByIdAsync(courseId);
            if (course == null)
                return BadRequest();

            var courseResult = new Course
            {
                CourseId = courseId,
                Name = updateRequest.Name
            };

            var updated = await _courseService.UpdateCourseAsync(courseResult);

            if (!updated)
                return NotFound();

            return Ok();
        }

        [HttpDelete(ApiRoutes.Course.Delete)]
        public async Task<IActionResult> DeleteCourse([FromRoute] string courseId)
        {
            var deleted = await _courseService.DeleteCourseAsync(courseId);

            if (deleted)
                return NoContent();

            return NotFound();
        }

        [HttpPost(ApiRoutes.Course.Create)]
        public async Task<IActionResult> CreateCourse([FromBody] CourseCreateRequest courseRequest)
        {
            var course = new Course { Name = courseRequest.Name };

            var created = await _courseService.CreateCourseAsync(course);

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = $"{baseUrl}/{ApiRoutes.Course.Get.Replace("{orderId}", course.CourseId.ToString())}";

            if (created)
                return Created(locationUri, course);

            return BadRequest(); 
        }

        [HttpGet(ApiRoutes.Course.getSubjectFromCourse)]
        public async Task<IActionResult> getSubjectFromCourse([FromRoute] string courseId)
        {
            var course = await _courseService.getSubjectFromCourseAsync(courseId);
            if(course == null)
                return NotFound();
            return Ok(course);
        }

        [HttpPost(ApiRoutes.Course.addSubjectToCourse)]
        public async Task<IActionResult> addSubjectToCourse([FromBody] CourseAddSubjectToCourseRequest request)
        {
            var added = await _courseService.addSubjectToCourseAsync(request.CourseId, request.SubjectId);

            if (added)
                return Ok();

            return BadRequest();
        }

        [HttpGet(ApiRoutes.Course.getAllSubjectAndCourse)]
        public async Task<IActionResult> getAllSubjectAndCourse()
        {
            var courses = await _courseService.getAllSubjectAndCourseAsync();

            if (courses == null)
                return NoContent();

            return Ok(courses);
        }

        [HttpDelete(ApiRoutes.Course.deleteSubjectFromCourse)]
        public async Task<IActionResult> deleteSubjectFromCourse([FromBody] CourseDeleteSubjectFromCourseRequest request)
        {
            var deleted = await _courseService.deleteSubjectFromCourseAsync(request.CourseId, request.SubjectId);

            if (deleted)
                return Ok();

            return BadRequest();
        }

        [HttpGet(ApiRoutes.Course.getStudentFromCourse)]
        public async Task<IActionResult> getStudentFromCourse([FromRoute] string courseId)
        {
            var student = await _courseService.getStudentFromCourseAsync(courseId);
            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpPost(ApiRoutes.Course.addStudentToCourse)]
        public async Task<IActionResult> addStudentToCourse([FromBody] CourseAddStudentToCourseRequest request)
        {
            var added = await _courseService.addStudentToCourseAsync(request.CourseId, request.StudentId);

            if (added)
                return Ok();

            return BadRequest();
        }

        [HttpGet(ApiRoutes.Course.getAllStudentAndCourse)]
        public async Task<IActionResult> getAllStudenttAndCourse()
        {
            var students = await _courseService.getAllStudentAndCourseAsync();

            if (students == null)
                return NoContent();

            return Ok(students);
        }

        [HttpDelete(ApiRoutes.Course.deleteStudentFromCourse)]
        public async Task<IActionResult> deleteStudentFromCourse([FromBody] CourseDeleteStudentFromCourseRequest request)
        {
            var deleted = await _courseService.deleteStudentFromCourseAsync(request.CourseId, request.StudentId);

            if (deleted)
                return Ok();

            return BadRequest();
        }
    }
}
