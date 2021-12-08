using AutoMapper;
using RayWebAPI.Entities;
using RayWebAPI.Models.Users;

namespace RayWebAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}