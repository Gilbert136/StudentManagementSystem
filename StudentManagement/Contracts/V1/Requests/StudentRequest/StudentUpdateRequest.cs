using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Requests.StudentRequest
{
    public class StudentUpdateRequest
    {
        public string email { get; set; }

        public string userName { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string gender { get; set; }

        public string courseId { get; set; }

        public string password { get; set; }
    }
}
