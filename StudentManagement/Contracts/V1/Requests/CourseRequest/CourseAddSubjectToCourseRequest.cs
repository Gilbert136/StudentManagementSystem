﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Requests.CourseRequest
{
    public class CourseAddSubjectToCourseRequest
    {
        public string CourseId { get; set; }

        public string SubjectId { get; set; }
    }
}
