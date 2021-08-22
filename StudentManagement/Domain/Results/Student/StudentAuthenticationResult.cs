using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Results
{
    public class StudentAuthenticationResult
    {
        public ApplicationUser User { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
