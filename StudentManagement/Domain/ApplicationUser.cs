using Microsoft.AspNetCore.Identity;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string UserType { get; set; }

        public DateTime TimeStamp { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }


        public string CourseId { get; set; }
        public Course course { get; set; }
    }
}
