using Ljubimci_API.DTOs;
using System.Threading.Tasks;

namespace Ljubimci_API.Services.Auth
{
    public interface IAuthService
    {
        public Task<OutputUserDTO> Login(InputLoginDTO loginDTO);
        public Task<OutputUserDTO> Register(InputRegisterDTO registerDTO);
    }
}
