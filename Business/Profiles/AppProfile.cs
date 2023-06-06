using Business.DTOs;
using Microsoft.AspNetCore.Identity;
using Music_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AppProfile : AutoMapper.Profile
    {
        public AppProfile()
        {
            CreateMap<Guitar, GuitarDTO>()
                .ForMember(d => d.ExtraProdsId, opt => opt.MapFrom(g => g.ExtraProductsId))
                .ForMember(d => d.ExtraProdName, opt => opt.MapFrom(g => g.ExtraProduct.Name));

            CreateMap<GuitarDTO, Guitar>()
                .ForMember(d => d.ExtraProductsId, opt => opt.MapFrom(g => g.ExtraProdsId));

            CreateMap<UserDTO, IdentityUser>()
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => s.Email))
                .ForMember(d => d.Id, opt => opt.Ignore());
        }
    }
}
