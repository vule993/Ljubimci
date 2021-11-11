using AutoMapper;
using Ljubimci_API.DTOs;
using Ljubimci_API.Entities;
using Ljubimci_API.Services.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Ljubimci_API.Controllers
{
    public class AuthController : BaseController
    {
        
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            
            this._authService = authService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<OutputUserDTO> Register(InputRegisterDTO registerDTO)
        {
            return await _authService.Register(registerDTO);
        }


        [Route("Login")]
        public async Task<OutputUserDTO> Login(InputLoginDTO loginDTO)
        {
            return await _authService.Login(loginDTO);
        }
    }
}
