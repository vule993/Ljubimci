using Ljubimci_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Interfaces
{
    public interface IUserRepository
    {
        //C
        Task<OutputUserDTO> CreateUser(InputRegisterDTO userDTO); 
        //R
        Task<IEnumerable<OutputUserDTO>> GetUsers(); 
        Task<OutputUserDTO> GetUser(int userId); 
        //U
        Task<OutputUserDTO> UpdateUser(OutputUserDTO userDTO); 
        //D
        Task<OutputUserDTO> DeleteUser(int userId); 
    }
}
