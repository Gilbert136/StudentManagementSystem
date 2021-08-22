using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Contracts.V1;
using StudentManagement.Contracts.V1.Requests.SubjectRequest;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
    public class SubjectController : Controller
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet(ApiRoutes.Subject.GetAll)]
        public async Task<IActionResult> GetSubjects()
        {
            var subjects = await _subjectService.GetAllSubjectAsync();

            if (subjects == null)
                return NotFound();

            return Ok(subjects);
        }

        [HttpGet(ApiRoutes.Subject.Get)]
        public async Task<IActionResult> Get([FromRoute] string subjectId)
        {
            var subjectWithNameResult = await _subjectService.GetSubjectByNameAsync(subjectId);
            if (subjectWithNameResult == null)
            {
                var subjectWithIdResult = await _subjectService.GetSubjectByIdAsync(subjectId);
                if (subjectWithIdResult == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(subjectWithIdResult);
                }
            }
            else
            {
                return Ok(subjectWithNameResult);
            }
        }

        [HttpPut(ApiRoutes.Subject.Update)]
        public async Task<IActionResult> UpdateSubject([FromRoute] string subjectId, [FromBody] SubjectUpdateRequest updateRequest)
        {
            var subject = await _subjectService.GetSubjectByIdAsync(subjectId);
            if (subject == null)
                return BadRequest();

            var subjectResult = new Subject
            {
                SubjectId = subjectId,
                Name = updateRequest.Name
            };

            var updated = await _subjectService.UpdateSubjectAsync(subjectResult);

            if (!updated)
                return NotFound();

            return Ok(subject);
        }

        [HttpDelete(ApiRoutes.Subject.Delete)]
        public async Task<IActionResult> DeleteSubject([FromRoute] string subjectId)
        {
            var deleted = await _subjectService.DeleteSubjectAsync(subjectId);

            if (deleted)
                return NoContent();
            
            return NotFound();
        }

        [HttpPost(ApiRoutes.Subject.Create)]
        public async Task<IActionResult> CreateSubject([FromBody] SubjectCreateRequest createRequest)
        {
            var subject = new Subject { Name = createRequest.Name };

            var created = await _subjectService.CreateSubjectAsync(subject);

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = $"{baseUrl}/{ApiRoutes.Subject.Get.Replace("{orderId}", subject.SubjectId.ToString())}";

            if (created)
                return Created(locationUri, subject);

            return BadRequest();
        }

        [HttpGet(ApiRoutes.Subject.getAllCourseAndSubject)]
        public async Task<IActionResult> getAllCourseAndSubject()
        {
            var subjects = await _subjectService.getAllCourseAndSubjectAsync();

            if (subjects == null)
                return NoContent();

            return Ok(subjects);
        }

        [HttpGet(ApiRoutes.Subject.getCourseFromSubject)]
        public async Task<IActionResult> getCourseFromSubject([FromRoute] string subjectId)
        {
            var course = await _subjectService.getCourseFromSubjectAsync(subjectId);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        [HttpPost(ApiRoutes.Subject.addCourseToSubject)]
        public async Task<IActionResult> addCourseToSubject([FromBody] SubjectAddCourseToSubjectRequest request)
        {
            var added = await _subjectService.addCourseToSubjectAsync(request.SubjectId, request.CourseId);

            if (added)
                return Ok();

            return BadRequest();
        }

        [HttpDelete(ApiRoutes.Subject.deleteCourseFromSubject)]
        public async Task<IActionResult> deleteCourseFromSubject([FromBody] SubjectDeleteCourseFromSubjectRequest request)
        {
            var deleted = await _subjectService.deleteCourseFromSubjectAsync(request.CourseId, request.SubjectId);

            if (deleted)
                return Ok();

            return BadRequest();
        }

    }
}
