using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Contracts.V1;
using StudentManagement.Contracts.V1.Requests.StudentRequest;
using StudentManagement.Contracts.V1.Responses;
using StudentManagement.Domain;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
    public class StudentController : Controller
    {
        private readonly IIdentityService _identityService;
        private readonly IStudentService _studentService;

        public StudentController(IIdentityService identityService, IStudentService studentService)
        {
            _identityService = identityService;
            _studentService = studentService;
        }

        [HttpPost(ApiRoutes.Student.Register)]
        public async Task<IActionResult> Register([FromBody] StudentRegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage))
                });
            }


            var user = new ApplicationUser
            {
                Email = request.Email,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender,
                UserType = "Student",
                TimeStamp = DateTime.Now
            };

            var authResponse = await _identityService.RegisterAsync(user, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse{ Errors = authResponse.Errors });
            }

            return Ok(new AuthSuccessResponse {   Token = authResponse.Token, User=authResponse.User });
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Student.Login)]
        public async Task<IActionResult> Login([FromBody] StudentLoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage))
                });
            }

            var authResponse = await _identityService.LoginAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token
            });
        }

        [HttpGet(ApiRoutes.Student.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var students = await _studentService.GetStudents();
            var ExtractedStudents = new List<StudentGetResponse>();
            foreach (var student in students)
            {
                ExtractedStudents.Add(new StudentGetResponse
                {
                    id = student.Id,
                    email = student.Email,
                    userName = student.UserName,
                    firstName = student.FirstName,
                    lastName = student.LastName,
                    gender = student.Gender,
                    course = student.course,
                    courseId = student.CourseId
                });
            }

            return Ok(ExtractedStudents);
        }

        [HttpGet(ApiRoutes.Student.Get)]
        public async Task<IActionResult> Get([FromRoute] string studentId)
        {
            var student = new ApplicationUser();

            var studentWithUsernameResult = await _studentService.GetStudentByUsernameAsync(studentId);
            if (!studentWithUsernameResult.Success)
            {
                var studentWithIdResult = await _studentService.GetStudentByIdAsync(studentId);
                if (!studentWithIdResult.Success)
                {
                    return NotFound(new AuthFailedResponse
                    {
                        Errors = studentWithIdResult.Errors
                    });
                }
                else {
                    student = studentWithIdResult.User;
                }
            }
            else {
                student = studentWithUsernameResult.User;
            }

            return Ok(new StudentGetResponse
            {
                id = student.Id,
                email = student.Email,
                userName = student.UserName,
                firstName = student.FirstName,
                lastName = student.LastName,
                gender = student.Gender,
                course = student.course
            });

        }

        [HttpPut(ApiRoutes.Student.Update)]
        public async Task<IActionResult> Update([FromRoute] string studentId, [FromBody] StudentUpdateRequest updateRequest)
        {
            var studentAuthResult = await _studentService.GetStudentByIdAsync(studentId);

            if (!studentAuthResult.Success)
            {
                return NotFound(new AuthFailedResponse
                {
                    Errors = studentAuthResult.Errors
                });
            }

            var student = studentAuthResult.User;

            if (updateRequest.password != "")
            {
                student.Email = updateRequest.email;
                student.UserName = updateRequest.userName;
                student.FirstName = updateRequest.firstName;
                student.LastName = updateRequest.lastName;
                student.Gender = updateRequest.gender;
            }
            else {
                var hasher = new PasswordHasher<ApplicationUser>();

                student.Email = updateRequest.email;
                student.UserName = updateRequest.userName;
                student.FirstName = updateRequest.firstName;
                student.LastName = updateRequest.lastName;
                student.Gender = updateRequest.gender;
                student.PasswordHash = hasher.HashPassword(null, updateRequest.password);
            };

        var studentResponse = await _studentService.UpdateStudentAsync(student);
            if (!studentResponse)
                return BadRequest();

            return Ok();
        }

        [HttpDelete(ApiRoutes.Student.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string studentId)
        {
            var deleted = await _studentService.DeleteStudentAsync(studentId);

            if (deleted)
                return NoContent();

            return NotFound();
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Student.addCourseToStudent)]
        public async Task<IActionResult> addCourseToStudent([FromBody] StudentAddCourseRequest request)
        {
            var result = await _studentService.AddCourseToStudentByIdAsync(request.StudentId, request.CourseId);

            if (result) return NoContent();

            return BadRequest();
        }

        [AllowAnonymous]
        [HttpDelete(ApiRoutes.Student.deleteCourseFromStudent)]
        public async Task<IActionResult> deleteCourseFromStudent([FromRoute] string studentId)
        {
            //check if course ID match the existing course
            var result = await _studentService.DeleteCourseFromStudentByIdAsync(studentId, null);

            if (result) return NoContent();

            return BadRequest();
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.Student.getCourseFromStudent)]
        public async Task<IActionResult> getCourseFromStudent([FromRoute] string studentId)
        {
            //check if course ID match the existing course
            var result = await _studentService.GetCourseFromStudentByIdAsync(studentId);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet(ApiRoutes.Student.getAllCourseAndStudent)]
        public async Task<IActionResult> getAllCourseAndStudent()
        {
            var students = await _studentService.getAllCourseAndStudentAsync();

            if (students == null)
                return NoContent();

            return Ok(students);
        }
    }
}
