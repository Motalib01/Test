using AutoMapper;
using Test.Dtos;
using Test.Models;

namespace Test.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}

