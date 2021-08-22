using StudentManagement.Domain;
using StudentManagement.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(ApplicationUser user, string password);

        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}
