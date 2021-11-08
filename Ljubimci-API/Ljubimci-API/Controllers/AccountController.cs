using AutoMapper;
using Ljubimci_API.Data;
using Ljubimci_API.DTOs;
using Ljubimci_API.Entities;
using Ljubimci_API.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<ActionResult<AppUserDTO>> Register(RegisterAppUserDTO registerAppUserDTO)
        {
            if (await UserExists(registerAppUserDTO.UserName)) return BadRequest("Username is taken.");

            var user = _mapper.Map<AppUser>(registerAppUserDTO);
            user.UserName = registerAppUserDTO.UserName.ToLower();

            var result = await _userManager.CreateAsync(user, registerAppUserDTO.Password);
            if (!result.Succeeded) return BadRequest(result.Errors);

            return _mapper.Map<AppUserDTO>(user);
        }

        private async Task<bool> UserExists(string userName) => await _userManager.Users.AnyAsync(user => user.UserName == userName.ToLower());
    }
}
