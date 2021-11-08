using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string City { get; set; }
        public List<AppUserRole> UserRoles { get; set; }
    }
}
