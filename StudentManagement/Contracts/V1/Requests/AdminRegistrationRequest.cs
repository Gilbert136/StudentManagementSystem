﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1.Requests
{
    public class AdminRegistrationRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
