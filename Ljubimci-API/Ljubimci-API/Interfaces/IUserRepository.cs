using Ljubimci_API.Data;
using Ljubimci_API.DTOs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Interfaces
{
    public interface IUserRepository
    {
        //C
        Task<AppUserDTO> CreateUser(RegisterAppUserDTO userDTO); 
        //R
        Task<IEnumerable<AppUserDTO>> GetUsers(); 
        Task<AppUserDTO> GetUser(int userId); 
        //U
        Task<AppUserDTO> UpdateUser(AppUserDTO userDTO); 
        //D
        Task<AppUserDTO> DeleteUser(int userId); 
    }
}
