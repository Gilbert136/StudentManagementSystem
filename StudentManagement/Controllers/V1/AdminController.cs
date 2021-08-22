using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Contracts.V1;
using StudentManagement.Contracts.V1.Requests;
using StudentManagement.Contracts.V1.Responses;
using StudentManagement.Domain;
using StudentManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers.V1
{
    [Authorize(AuthenticationSchemes= JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IIdentityService _identityService;

        public AdminController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        
        [HttpPost(ApiRoutes.Admin.Register)]
        public async Task<IActionResult> Register([FromBody] AdminRegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage))
                });
            }

            var user = new ApplicationUser
            {
                Email = request.Email,
                UserName = request.Email,
                UserType = "Administrator",
                TimeStamp = DateTime.Now
            };

            var authResponse = await _identityService.RegisterAsync(user, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                User = authResponse.User,

                Token = authResponse.Token
            });
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Admin.Login)]
        public async Task<IActionResult> Login([FromBody] AdminLoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage))
                });
            }

            var authResponse = await _identityService.LoginAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                User = authResponse.User,

                Token = authResponse.Token
            });
        }
    }
    
}
