using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        //public string Password { get; set; }

        public string UserType { get; set; }
        public DateTime TimeStamp { get; set; }

        public string CourseId { get; set; }
        public Course course { get; set; }

    }
}
