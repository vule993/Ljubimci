using Ljubimci_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.DTOs
{
    public class OutputUserDTO
    {
        public AppUser User { get; set; }
        public string Token { get; set; }
    }
}
