using AutoMapper;
using Ljubimci_API.Data;
using Ljubimci_API.DTOs;
using Ljubimci_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljubimci_API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //automatski ce da mapira polja iz appuser u appuserdto
            CreateMap<AppUser, AppUserDTO>();
        }
    }
}
