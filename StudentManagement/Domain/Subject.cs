using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string Name { get; set; }

        public string CourseId { get; set; }
        public Course course { get; set; }
    }
}
