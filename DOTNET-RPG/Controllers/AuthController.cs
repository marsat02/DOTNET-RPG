﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DOTNET_RPG.Dtos.User;
using DOTNET_RPG.Models;
using DOTNET_RPG.Data;

namespace DOTNET_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase 
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(new User {Username = request.Username}, request.Password);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
        
        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}