using Ljubimci_API.Entities;
using System.Threading.Tasks;

namespace Ljubimci_API.Services.Auth
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
