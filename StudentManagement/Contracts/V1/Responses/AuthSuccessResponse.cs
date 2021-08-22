using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Responses
{
    public class AuthSuccessResponse
    {
        //Once you register you users you must verify their email (reminder)
        public string Token { get; set; }

        public ApplicationUser User { get; set; }
    }
}
