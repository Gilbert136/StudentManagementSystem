using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using StudentManagement.Domain;
using StudentManagement.Domain.Results;
using StudentManagement.Options;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{

    public class IdentityService : TokenService, IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtSettings _jwtSettings;
        private readonly RoleManager<IdentityRole> _roleManager;


        public IdentityService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, JwtSettings jwtSettings)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtSettings = jwtSettings;
        }

        public async Task<AuthenticationResult> LoginAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return new AuthenticationResult { Errors = new[] { "User does not exists" } };
            }

            var userHasValidPassword = await _userManager.CheckPasswordAsync(user, password);

            if (!userHasValidPassword)
            {
                return new AuthenticationResult
                {
                    Errors = new[] { "User/Password combination is wrong" }
                };
            }

            return GenerateUserToken(user, _jwtSettings);
        }

        public async Task<AuthenticationResult> RegisterAsync(ApplicationUser user, string password)
        {
            var existingUser = await _userManager.FindByEmailAsync(user.Email);

            if (existingUser != null)
            {
                return new AuthenticationResult { Errors = new[] { "User with this email address already exists:" } };
            }

            var createdUser = await _userManager.CreateAsync(user, password);

            if (!createdUser.Succeeded)
            {
                
                return new AuthenticationResult
                {
                    Errors = createdUser.Errors.Select(options => options.Description)
                };
            }
            else
            {
                //Add userRole to users
                await _userManager.AddToRoleAsync(user, user.UserType);
            }

            return GenerateUserToken(user, _jwtSettings);
        }

    }
}
