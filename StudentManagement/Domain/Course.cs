using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
