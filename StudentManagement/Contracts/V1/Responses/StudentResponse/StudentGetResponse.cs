using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Responses
{
    public class StudentGetResponse
    {
        public string id { get; set; }

        public string email { get; set; }

        public string userName { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string gender { get; set; }

        public Course course { get; set; }

        public string courseId { get; set; }
    }
}
