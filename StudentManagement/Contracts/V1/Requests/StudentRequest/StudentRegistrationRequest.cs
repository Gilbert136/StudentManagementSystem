using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Requests.StudentRequest
{
    public class StudentRegistrationRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; } 

        [EmailAddress]
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Gender { get; set; }

        public string Password { get; set; }
    }
}
