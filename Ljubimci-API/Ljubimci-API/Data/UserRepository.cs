using AutoMapper;
using Ljubimci_API.DTOs;
using Ljubimci_API.Entities;
using Ljubimci_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<AppUserDTO> CreateUser(RegisterAppUserDTO registerAppUserDTO)
        {
            var user = new AppUser()
            {
                UserName = registerAppUserDTO.UserName,
                Email = registerAppUserDTO.Email,
                PhoneNumber = registerAppUserDTO.PhoneNumber,
                City = registerAppUserDTO.City,
                PasswordHash = registerAppUserDTO.Password
            };

            return null;
        }

        public Task<AppUserDTO> DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserDTO> GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppUserDTO>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<AppUserDTO> UpdateUser(AppUserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
