using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ePolicyDTO = MyProject.Common.DTOs.ePolicy;
using ePolicy = MyProject.Repositories.Entities.ePolicy;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>()
                .ForMember(dest=>dest.DescriptionDTO,op=>op.MapFrom(src=>src.Descripsion))
                .ReverseMap();
            CreateMap<Permission, PermissionDTO>()
                .ForMember(dest=>dest.DescriptionDTO,op=>op.MapFrom(src=>src.Descripsion))
                .ReverseMap();
            CreateMap<Claim, ClaimDTO>().ReverseMap();
            CreateMap<ePolicy, ePolicyDTO>().ReverseMap();
        }
    }
}
