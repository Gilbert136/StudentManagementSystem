using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Requests.CourseRequest
{
    public class CourseDeleteStudentFromCourseRequest
    {
        public string CourseId { get; set; }

        public string StudentId { get; set; }
    }
}
