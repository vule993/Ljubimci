using AutoMapper;
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
            CreateMap<AppUser, OutputUserDTO>()
                .ForMember(
                    destination => destination.Token,
                    options => options.MapFrom(source => source)
                );
            CreateMap<AppUser, InputRegisterDTO>();
            CreateMap<InputRegisterDTO, AppUser>();
        }
    }
}
