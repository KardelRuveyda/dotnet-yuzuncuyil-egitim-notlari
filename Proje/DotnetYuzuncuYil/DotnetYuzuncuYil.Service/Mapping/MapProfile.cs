using AutoMapper;
using DotnetYuzuncuYil.Core;
using DotnetYuzuncuYil.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();

            //dto'dan entity'e çevirmek istersem;
            CreateMap<TeamDto, Team>();
            CreateMap<UserDto, User>();
            CreateMap<UserProfileDto, UserProfile>();
        }
    }
}
