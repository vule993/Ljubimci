using AutoMapper;
using Ljubimci_API.DTOs;
using Ljubimci_API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks;


namespace Ljubimci_API.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<OutputUserDTO> Login(InputLoginDTO loginDTO)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.UserName == loginDTO.UserName.ToLower());
            if (user == null) throw new KeyNotFoundException("Invalid username.");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);
            if (!result.Succeeded) throw new AuthenticationException("Unauthorized.");


            var dtoToReturn = _mapper.Map<OutputUserDTO>(user);
            dtoToReturn.Token = await _tokenService.CreateToken(user);

            return dtoToReturn;
        }

        public async Task<OutputUserDTO> Register(InputRegisterDTO registerDTO)
        {
            if (await UserExists(registerDTO.UserName)) throw new Exception();

            var user = _mapper.Map<AppUser>(registerDTO);
            user.UserName = registerDTO.UserName.ToLower();

            var result = await _userManager.CreateAsync(user, registerDTO.Password);
            if (!result.Succeeded) throw new AuthenticationException(result.Errors.ToString());

            var dtoToReturn = _mapper.Map<OutputUserDTO>(user);
            dtoToReturn.Token = await _tokenService.CreateToken(user);
            return dtoToReturn;
        }

        private async Task<bool> UserExists(string userName) => await _userManager.Users.AnyAsync(user => user.UserName == userName.ToLower());

    }
}
