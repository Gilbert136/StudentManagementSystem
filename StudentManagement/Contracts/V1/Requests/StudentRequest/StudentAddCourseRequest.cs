using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Requests.StudentRequest
{
    public class StudentAddCourseRequest
    {
        public string StudentId { get; set; }

        public string CourseId { get; set; }
    }
}
