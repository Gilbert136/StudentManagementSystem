using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Results.Student
{
    public class StudentGetCourseResult
    {
        public Course course { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
