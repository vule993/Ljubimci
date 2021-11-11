using Ljubimci_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Services.User
{
    public interface IUserService
    {
        public AppUser Get();
        public IEnumerable<AppUser> GetAll();
        public AppUser Update(AppUser user);
        public void Delete(AppUser user);
    }
}
